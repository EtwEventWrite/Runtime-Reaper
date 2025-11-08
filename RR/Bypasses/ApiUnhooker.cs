using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RR.Bypasses
{
    public class ApiUnhooker
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct MODULEINFO
        {
            public IntPtr BaseOfDll;
            public uint SizeOfImage;
            public IntPtr EntryPoint;
        }

        private static CloseHandleD CloseHandle = Marshal.GetDelegateForFunctionPointer<CloseHandleD>(GetLibraryAddress("kernel32.dll", "CloseHandle"));
        private static FreeLibraryD FreeLibrary = Marshal.GetDelegateForFunctionPointer<FreeLibraryD>(GetLibraryAddress("kernel32.dll", "FreeLibrary"));
        private static VirtualProtectD VirtualProtectA = Marshal.GetDelegateForFunctionPointer<VirtualProtectD>(GetLibraryAddress("kernel32.dll", "VirtualProtect"));
        private static CreateFileAD CreateFileA = Marshal.GetDelegateForFunctionPointer<CreateFileAD>(GetLibraryAddress("kernel32.dll", "CreateFileA"));
        private static CreateFileMappingD CreateFileMapping = Marshal.GetDelegateForFunctionPointer<CreateFileMappingD>(GetLibraryAddress("kernel32.dll", "CreateFileMappingA"));
        private static MapViewOfFileD MapViewOfFile = Marshal.GetDelegateForFunctionPointer<MapViewOfFileD>(GetLibraryAddress("kernel32.dll", "MapViewOfFile"));
        private static memcpyD memcpy = Marshal.GetDelegateForFunctionPointer<memcpyD>(GetLibraryAddress("msvcrt.dll", "memcpy"));
        private static GetModuleInformationD GetModuleInformation = Marshal.GetDelegateForFunctionPointer<GetModuleInformationD>(GetLibraryAddress("psapi.dll", "GetModuleInformation"));
        private static IsWow64ProcessD IsWow64Process = Marshal.GetDelegateForFunctionPointer<IsWow64ProcessD>(GetLibraryAddress("kernel32.dll", "IsWow64Process"));

        private delegate bool CloseHandleD(IntPtr handle);

        private delegate bool FreeLibraryD(IntPtr module);

        private delegate int VirtualProtectD(IntPtr address, IntPtr size, uint newProtect, out uint oldProtect);

        private delegate IntPtr CreateFileAD(string fileName, uint desiredAccess, uint shareMode, IntPtr securityAttributes, uint creationDisposition, uint flagsAndAttributes, IntPtr templateFile);

        private delegate IntPtr CreateFileMappingD(IntPtr file, IntPtr fileMappingAttributes, uint protect, uint maximumSizeHigh, uint maximumSizeLow, string name);

        private delegate IntPtr MapViewOfFileD(IntPtr fileMappingObject, uint desiredAccess, uint fileOffsetHigh, uint fileOffsetLow, IntPtr numberOfBytesToMap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr memcpyD(IntPtr dest, IntPtr src, IntPtr count);

        private delegate bool GetModuleInformationD(IntPtr process, IntPtr module, out MODULEINFO moduleInfo, uint size);

        private delegate bool IsWow64ProcessD([In] IntPtr hProcess, [Out] out bool wow64Process);

        private static IntPtr GetExportAddress(IntPtr ModuleBase, string ExportName)
        {
            IntPtr FunctionPtr = IntPtr.Zero;
            try
            {
                Int32 PeHeader = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + 0x3C));
                Int16 OptHeaderSize = Marshal.ReadInt16((IntPtr)(ModuleBase.ToInt64() + PeHeader + 0x14));
                Int64 OptHeader = ModuleBase.ToInt64() + PeHeader + 0x18;
                Int16 Magic = Marshal.ReadInt16((IntPtr)OptHeader);
                Int64 pExport = 0;
                if (Magic == 0x010b)
                {
                    pExport = OptHeader + 0x60;
                }
                else
                {
                    pExport = OptHeader + 0x70;
                }

                Int32 ExportRVA = Marshal.ReadInt32((IntPtr)pExport);
                Int32 OrdinalBase = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x10));
                Int32 NumberOfFunctions = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x14));
                Int32 NumberOfNames = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x18));
                Int32 FunctionsRVA = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x1C));
                Int32 NamesRVA = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x20));
                Int32 OrdinalsRVA = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + ExportRVA + 0x24));

                for (int i = 0; i < NumberOfNames; i++)
                {
                    string FunctionName = Marshal.PtrToStringAnsi((IntPtr)(ModuleBase.ToInt64() + Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + NamesRVA + i * 4))));
                    if (FunctionName.Equals(ExportName, StringComparison.OrdinalIgnoreCase))
                    {
                        Int32 FunctionOrdinal = Marshal.ReadInt16((IntPtr)(ModuleBase.ToInt64() + OrdinalsRVA + i * 2)) + OrdinalBase;
                        Int32 FunctionRVA = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + FunctionsRVA + (4 * (FunctionOrdinal - OrdinalBase))));
                        FunctionPtr = (IntPtr)((Int64)ModuleBase + FunctionRVA);
                        break;
                    }
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }

            if (FunctionPtr == IntPtr.Zero)
            {
                throw new MissingMethodException();
            }
            return FunctionPtr;
        }

        private static IntPtr GetLibraryAddress(string DLLName, string FunctionName)
        {
            return GetExportAddress(GetLoadedModuleAddress(DLLName), FunctionName);
        }

        private static IntPtr GetLoadedModuleAddress(string DLLName)
        {
            ProcessModuleCollection ProcModules = Process.GetCurrentProcess().Modules;
            foreach (ProcessModule Mod in ProcModules)
            {
                if (Mod.FileName.ToLower().EndsWith(DLLName.ToLower()))
                {
                    return Mod.BaseAddress;
                }
            }
            return IntPtr.Zero;
        }

        [HandleProcessCorruptedStateExceptions]
        internal static unsafe void Unhook(string a)
        {
            try
            {
                bool wow64;
                IsWow64Process(Process.GetCurrentProcess().Handle, out wow64);

                string systemDirectory = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\";
                if (wow64 && IntPtr.Size == 4)
                {
                    systemDirectory = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\SysWOW64\";
                }

                IntPtr dll = GetLoadedModuleAddress(a);
                if (dll == IntPtr.Zero) return;
                MODULEINFO moduleInfo;
                if (!GetModuleInformation(Process.GetCurrentProcess().Handle, dll, out moduleInfo, (uint)sizeof(MODULEINFO))) return;

                IntPtr dllFile = CreateFileA(systemDirectory + a, 0x80000000, 1, IntPtr.Zero, 3, 0, IntPtr.Zero);
                if (dllFile == (IntPtr)(-1))
                {
                    CloseHandle(dllFile);
                    return;
                }

                IntPtr dllMapping = CreateFileMapping(dllFile, IntPtr.Zero, 0x1000002, 0, 0, null);
                if (dllMapping == IntPtr.Zero)
                {
                    CloseHandle(dllMapping);
                    return;
                }

                IntPtr dllMappedFile = MapViewOfFile(dllMapping, 4, 0, 0, IntPtr.Zero);
                if (dllMappedFile == IntPtr.Zero) return;

                int ntHeaders = Marshal.ReadInt32((IntPtr)((long)moduleInfo.BaseOfDll + 0x3c));
                short numberOfSections = Marshal.ReadInt16((IntPtr)((long)dll + ntHeaders + 0x6));
                short sizeOfOptionalHeader = Marshal.ReadInt16(dll, ntHeaders + 0x14);

                for (short i = 0; i < numberOfSections; i++)
                {
                    IntPtr sectionHeader = (IntPtr)((long)dll + ntHeaders + 0x18 + sizeOfOptionalHeader + i * 0x28);
                    if (Marshal.ReadByte(sectionHeader) == '.' &&
                        Marshal.ReadByte((IntPtr)((long)sectionHeader + 1)) == 't' &&
                        Marshal.ReadByte((IntPtr)((long)sectionHeader + 2)) == 'e' &&
                        Marshal.ReadByte((IntPtr)((long)sectionHeader + 3)) == 'x' &&
                        Marshal.ReadByte((IntPtr)((long)sectionHeader + 4)) == 't')
                    {
                        int virtualAddress = Marshal.ReadInt32((IntPtr)((long)sectionHeader + 0xc));
                        uint virtualSize = (uint)Marshal.ReadInt32((IntPtr)((long)sectionHeader + 0x8));
                        uint oldProtect;
                        VirtualProtectA((IntPtr)((long)dll + virtualAddress), (IntPtr)virtualSize, 0x40, out oldProtect);
                        memcpy((IntPtr)((long)dll + virtualAddress), (IntPtr)((long)dllMappedFile + virtualAddress), (IntPtr)virtualSize);
                        VirtualProtectA((IntPtr)((long)dll + virtualAddress), (IntPtr)virtualSize, oldProtect, out oldProtect);
                        break;
                    }
                }

                CloseHandle(dllMapping);
                CloseHandle(dllFile);
                FreeLibrary(dll);
            }
            catch
            {
            }
        }
    }
}
