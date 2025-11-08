namespace RR.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.groupStubConfig = new System.Windows.Forms.GroupBox();
            this.chkSaveChoice = new System.Windows.Forms.CheckBox();
            this.comboOutputType = new System.Windows.Forms.ComboBox();
            this.groupEXE = new System.Windows.Forms.GroupBox();
            this.comboHollowing = new System.Windows.Forms.ComboBox();
            this.chkStackSpoofer = new System.Windows.Forms.CheckBox();
            this.chkAPIUnhooker = new System.Windows.Forms.CheckBox();
            this.chkProcessInjection = new System.Windows.Forms.CheckBox();
            this.chkCLRPatch = new System.Windows.Forms.CheckBox();
            this.chkEtwBypass = new System.Windows.Forms.CheckBox();
            this.chkAmsiPatch = new System.Windows.Forms.CheckBox();
            this.groupDLL = new System.Windows.Forms.GroupBox();
            this.chkInvalidCodeSig = new System.Windows.Forms.CheckBox();
            this.chkDLLSearchOrder = new System.Windows.Forms.CheckBox();
            this.chkTrustedProcessAbuse = new System.Windows.Forms.CheckBox();
            this.chkApplicationWhitelist = new System.Windows.Forms.CheckBox();
            this.groupDLL2 = new System.Windows.Forms.GroupBox();
            this.chkRegAsmAbuse = new System.Windows.Forms.CheckBox();
            this.chkAssemblyLoadTrigger = new System.Windows.Forms.CheckBox();
            this.chkCLRHostBypass = new System.Windows.Forms.CheckBox();
            this.chkAppDomainMan = new System.Windows.Forms.CheckBox();
            this.groupDLL3 = new System.Windows.Forms.GroupBox();
            this.chkModuleStomping = new System.Windows.Forms.CheckBox();
            this.chkDoppelganging = new System.Windows.Forms.CheckBox();
            this.chkManualMapping = new System.Windows.Forms.CheckBox();
            this.chkReflectiveDLLInjection = new System.Windows.Forms.CheckBox();
            this.groupPS1 = new System.Windows.Forms.GroupBox();
            this.chkCLMBypass = new System.Windows.Forms.CheckBox();
            this.chkLoggingBypass = new System.Windows.Forms.CheckBox();
            this.chkConstraintedEscape = new System.Windows.Forms.CheckBox();
            this.chkAmsiPatchP = new System.Windows.Forms.CheckBox();
            this.groupLogging = new System.Windows.Forms.GroupBox();
            this.lstLogging = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.debugTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuild = new System.Windows.Forms.Button();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.groupStubConfig.SuspendLayout();
            this.groupEXE.SuspendLayout();
            this.groupDLL.SuspendLayout();
            this.groupDLL2.SuspendLayout();
            this.groupDLL3.SuspendLayout();
            this.groupPS1.SuspendLayout();
            this.groupLogging.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(367, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(32, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(4, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 23);
            this.txtInput.TabIndex = 1;
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(320, 404);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(79, 13);
            this.linkAbout.TabIndex = 2;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "Documentation";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // groupStubConfig
            // 
            this.groupStubConfig.Controls.Add(this.chkSaveChoice);
            this.groupStubConfig.Controls.Add(this.comboOutputType);
            this.groupStubConfig.Location = new System.Drawing.Point(4, 33);
            this.groupStubConfig.Name = "groupStubConfig";
            this.groupStubConfig.Size = new System.Drawing.Size(395, 48);
            this.groupStubConfig.TabIndex = 3;
            this.groupStubConfig.TabStop = false;
            this.groupStubConfig.Text = "Output Configuration";
            // 
            // chkSaveChoice
            // 
            this.chkSaveChoice.AutoSize = true;
            this.chkSaveChoice.Checked = true;
            this.chkSaveChoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveChoice.Location = new System.Drawing.Point(304, 20);
            this.chkSaveChoice.Name = "chkSaveChoice";
            this.chkSaveChoice.Size = new System.Drawing.Size(87, 17);
            this.chkSaveChoice.TabIndex = 5;
            this.chkSaveChoice.Text = "Save Choice";
            this.chkSaveChoice.UseVisualStyleBackColor = true;
            // 
            // comboOutputType
            // 
            this.comboOutputType.FormattingEnabled = true;
            this.comboOutputType.Items.AddRange(new object[] {
            ".exe [Windows Executable]",
            ".exe [DLL Sideloading]",
            ".dll  [Dynamic Link Library .NET]",
            ".dll  [Dynamic Link Library Native]",
            ".ps1 [PowerShell Script]"});
            this.comboOutputType.Location = new System.Drawing.Point(7, 18);
            this.comboOutputType.Name = "comboOutputType";
            this.comboOutputType.Size = new System.Drawing.Size(291, 21);
            this.comboOutputType.TabIndex = 4;
            this.comboOutputType.SelectedIndexChanged += new System.EventHandler(this.comboOutputType_SelectedIndexChanged);
            // 
            // groupEXE
            // 
            this.groupEXE.Controls.Add(this.comboHollowing);
            this.groupEXE.Controls.Add(this.chkStackSpoofer);
            this.groupEXE.Controls.Add(this.chkAPIUnhooker);
            this.groupEXE.Controls.Add(this.chkProcessInjection);
            this.groupEXE.Controls.Add(this.chkCLRPatch);
            this.groupEXE.Controls.Add(this.chkEtwBypass);
            this.groupEXE.Controls.Add(this.chkAmsiPatch);
            this.groupEXE.Location = new System.Drawing.Point(0, 0);
            this.groupEXE.Name = "groupEXE";
            this.groupEXE.Size = new System.Drawing.Size(395, 143);
            this.groupEXE.TabIndex = 4;
            this.groupEXE.TabStop = false;
            this.groupEXE.Text = "Stub Configuration | Windows Executable";
            // 
            // comboHollowing
            // 
            this.comboHollowing.Enabled = false;
            this.comboHollowing.FormattingEnabled = true;
            this.comboHollowing.Items.AddRange(new object[] {
            "notepad.exe",
            "calc.exe",
            "svchost.exe"});
            this.comboHollowing.Location = new System.Drawing.Point(182, 81);
            this.comboHollowing.Name = "comboHollowing";
            this.comboHollowing.Size = new System.Drawing.Size(121, 21);
            this.comboHollowing.TabIndex = 6;
            // 
            // chkStackSpoofer
            // 
            this.chkStackSpoofer.AutoSize = true;
            this.chkStackSpoofer.Location = new System.Drawing.Point(182, 22);
            this.chkStackSpoofer.Name = "chkStackSpoofer";
            this.chkStackSpoofer.Size = new System.Drawing.Size(94, 17);
            this.chkStackSpoofer.TabIndex = 5;
            this.chkStackSpoofer.Text = "Stack Spoofer";
            this.chkStackSpoofer.UseVisualStyleBackColor = true;
            // 
            // chkAPIUnhooker
            // 
            this.chkAPIUnhooker.AutoSize = true;
            this.chkAPIUnhooker.Location = new System.Drawing.Point(12, 105);
            this.chkAPIUnhooker.Name = "chkAPIUnhooker";
            this.chkAPIUnhooker.Size = new System.Drawing.Size(93, 17);
            this.chkAPIUnhooker.TabIndex = 4;
            this.chkAPIUnhooker.Text = "API Unhooker";
            this.chkAPIUnhooker.UseVisualStyleBackColor = true;
            // 
            // chkProcessInjection
            // 
            this.chkProcessInjection.AutoSize = true;
            this.chkProcessInjection.Location = new System.Drawing.Point(12, 84);
            this.chkProcessInjection.Name = "chkProcessInjection";
            this.chkProcessInjection.Size = new System.Drawing.Size(162, 17);
            this.chkProcessInjection.TabIndex = 3;
            this.chkProcessInjection.Text = "Process Hollowing [Injection]";
            this.chkProcessInjection.UseVisualStyleBackColor = true;
            this.chkProcessInjection.CheckedChanged += new System.EventHandler(this.chkProcessInjection_CheckedChanged);
            // 
            // chkCLRPatch
            // 
            this.chkCLRPatch.AutoSize = true;
            this.chkCLRPatch.Location = new System.Drawing.Point(12, 63);
            this.chkCLRPatch.Name = "chkCLRPatch";
            this.chkCLRPatch.Size = new System.Drawing.Size(69, 17);
            this.chkCLRPatch.TabIndex = 2;
            this.chkCLRPatch.Text = "Clr Patch";
            this.chkCLRPatch.UseVisualStyleBackColor = true;
            // 
            // chkEtwBypass
            // 
            this.chkEtwBypass.AutoSize = true;
            this.chkEtwBypass.Location = new System.Drawing.Point(12, 42);
            this.chkEtwBypass.Name = "chkEtwBypass";
            this.chkEtwBypass.Size = new System.Drawing.Size(75, 17);
            this.chkEtwBypass.TabIndex = 1;
            this.chkEtwBypass.Text = "Etw Patch";
            this.chkEtwBypass.UseVisualStyleBackColor = true;
            // 
            // chkAmsiPatch
            // 
            this.chkAmsiPatch.AutoSize = true;
            this.chkAmsiPatch.Location = new System.Drawing.Point(12, 22);
            this.chkAmsiPatch.Name = "chkAmsiPatch";
            this.chkAmsiPatch.Size = new System.Drawing.Size(79, 17);
            this.chkAmsiPatch.TabIndex = 0;
            this.chkAmsiPatch.Text = "Amsi Patch";
            this.chkAmsiPatch.UseVisualStyleBackColor = true;
            // 
            // groupDLL
            // 
            this.groupDLL.Controls.Add(this.chkInvalidCodeSig);
            this.groupDLL.Controls.Add(this.chkDLLSearchOrder);
            this.groupDLL.Controls.Add(this.chkTrustedProcessAbuse);
            this.groupDLL.Controls.Add(this.chkApplicationWhitelist);
            this.groupDLL.Location = new System.Drawing.Point(4, 85);
            this.groupDLL.Name = "groupDLL";
            this.groupDLL.Size = new System.Drawing.Size(395, 143);
            this.groupDLL.TabIndex = 7;
            this.groupDLL.TabStop = false;
            this.groupDLL.Text = "Stub Configuration | DLL Sideloading";
            // 
            // chkInvalidCodeSig
            // 
            this.chkInvalidCodeSig.AutoSize = true;
            this.chkInvalidCodeSig.Location = new System.Drawing.Point(12, 89);
            this.chkInvalidCodeSig.Name = "chkInvalidCodeSig";
            this.chkInvalidCodeSig.Size = new System.Drawing.Size(133, 17);
            this.chkInvalidCodeSig.TabIndex = 4;
            this.chkInvalidCodeSig.Text = "Invalid Code Signature";
            this.chkInvalidCodeSig.UseVisualStyleBackColor = true;
            // 
            // chkDLLSearchOrder
            // 
            this.chkDLLSearchOrder.AutoSize = true;
            this.chkDLLSearchOrder.Location = new System.Drawing.Point(12, 67);
            this.chkDLLSearchOrder.Name = "chkDLLSearchOrder";
            this.chkDLLSearchOrder.Size = new System.Drawing.Size(159, 17);
            this.chkDLLSearchOrder.TabIndex = 3;
            this.chkDLLSearchOrder.Text = "DLL Search Order Hijacking";
            this.chkDLLSearchOrder.UseVisualStyleBackColor = true;
            // 
            // chkTrustedProcessAbuse
            // 
            this.chkTrustedProcessAbuse.AutoSize = true;
            this.chkTrustedProcessAbuse.Location = new System.Drawing.Point(12, 44);
            this.chkTrustedProcessAbuse.Name = "chkTrustedProcessAbuse";
            this.chkTrustedProcessAbuse.Size = new System.Drawing.Size(136, 17);
            this.chkTrustedProcessAbuse.TabIndex = 2;
            this.chkTrustedProcessAbuse.Text = "Trusted Process Abuse";
            this.chkTrustedProcessAbuse.UseVisualStyleBackColor = true;
            // 
            // chkApplicationWhitelist
            // 
            this.chkApplicationWhitelist.AutoSize = true;
            this.chkApplicationWhitelist.Location = new System.Drawing.Point(12, 22);
            this.chkApplicationWhitelist.Name = "chkApplicationWhitelist";
            this.chkApplicationWhitelist.Size = new System.Drawing.Size(158, 17);
            this.chkApplicationWhitelist.TabIndex = 1;
            this.chkApplicationWhitelist.Text = "Application Whitelist Bypass";
            this.chkApplicationWhitelist.UseVisualStyleBackColor = true;
            // 
            // groupDLL2
            // 
            this.groupDLL2.Controls.Add(this.chkRegAsmAbuse);
            this.groupDLL2.Controls.Add(this.chkAssemblyLoadTrigger);
            this.groupDLL2.Controls.Add(this.chkCLRHostBypass);
            this.groupDLL2.Controls.Add(this.chkAppDomainMan);
            this.groupDLL2.Location = new System.Drawing.Point(4, 88);
            this.groupDLL2.Name = "groupDLL2";
            this.groupDLL2.Size = new System.Drawing.Size(395, 141);
            this.groupDLL2.TabIndex = 8;
            this.groupDLL2.TabStop = false;
            this.groupDLL2.Text = "Stub Configuration | Dynamic Link Library [.NET]";
            // 
            // chkRegAsmAbuse
            // 
            this.chkRegAsmAbuse.AutoSize = true;
            this.chkRegAsmAbuse.Location = new System.Drawing.Point(12, 89);
            this.chkRegAsmAbuse.Name = "chkRegAsmAbuse";
            this.chkRegAsmAbuse.Size = new System.Drawing.Size(146, 17);
            this.chkRegAsmAbuse.TabIndex = 8;
            this.chkRegAsmAbuse.Text = "RegAsm/InstallUtil Abuse";
            this.chkRegAsmAbuse.UseVisualStyleBackColor = true;
            // 
            // chkAssemblyLoadTrigger
            // 
            this.chkAssemblyLoadTrigger.AutoSize = true;
            this.chkAssemblyLoadTrigger.Location = new System.Drawing.Point(12, 67);
            this.chkAssemblyLoadTrigger.Name = "chkAssemblyLoadTrigger";
            this.chkAssemblyLoadTrigger.Size = new System.Drawing.Size(170, 17);
            this.chkAssemblyLoadTrigger.TabIndex = 7;
            this.chkAssemblyLoadTrigger.Text = "Assembly Load Trigger Bypass";
            this.chkAssemblyLoadTrigger.UseVisualStyleBackColor = true;
            // 
            // chkCLRHostBypass
            // 
            this.chkCLRHostBypass.AutoSize = true;
            this.chkCLRHostBypass.Location = new System.Drawing.Point(12, 45);
            this.chkCLRHostBypass.Name = "chkCLRHostBypass";
            this.chkCLRHostBypass.Size = new System.Drawing.Size(123, 17);
            this.chkCLRHostBypass.TabIndex = 6;
            this.chkCLRHostBypass.Text = "CLR Hosting Bypass";
            this.chkCLRHostBypass.UseVisualStyleBackColor = true;
            // 
            // chkAppDomainMan
            // 
            this.chkAppDomainMan.AutoSize = true;
            this.chkAppDomainMan.Location = new System.Drawing.Point(12, 23);
            this.chkAppDomainMan.Name = "chkAppDomainMan";
            this.chkAppDomainMan.Size = new System.Drawing.Size(159, 17);
            this.chkAppDomainMan.TabIndex = 5;
            this.chkAppDomainMan.Text = "AppDomain Manager Hijack";
            this.chkAppDomainMan.UseVisualStyleBackColor = true;
            // 
            // groupDLL3
            // 
            this.groupDLL3.Controls.Add(this.groupEXE);
            this.groupDLL3.Controls.Add(this.chkModuleStomping);
            this.groupDLL3.Controls.Add(this.chkDoppelganging);
            this.groupDLL3.Controls.Add(this.chkManualMapping);
            this.groupDLL3.Controls.Add(this.chkReflectiveDLLInjection);
            this.groupDLL3.Location = new System.Drawing.Point(4, 85);
            this.groupDLL3.Name = "groupDLL3";
            this.groupDLL3.Size = new System.Drawing.Size(395, 144);
            this.groupDLL3.TabIndex = 8;
            this.groupDLL3.TabStop = false;
            this.groupDLL3.Text = "Stub Configuration | Dynamic Link Library [Native]";
            // 
            // chkModuleStomping
            // 
            this.chkModuleStomping.AutoSize = true;
            this.chkModuleStomping.Location = new System.Drawing.Point(12, 87);
            this.chkModuleStomping.Name = "chkModuleStomping";
            this.chkModuleStomping.Size = new System.Drawing.Size(108, 17);
            this.chkModuleStomping.TabIndex = 4;
            this.chkModuleStomping.Text = "Module Stomping";
            this.chkModuleStomping.UseVisualStyleBackColor = true;
            // 
            // chkDoppelganging
            // 
            this.chkDoppelganging.AutoSize = true;
            this.chkDoppelganging.Location = new System.Drawing.Point(12, 65);
            this.chkDoppelganging.Name = "chkDoppelganging";
            this.chkDoppelganging.Size = new System.Drawing.Size(139, 17);
            this.chkDoppelganging.TabIndex = 3;
            this.chkDoppelganging.Text = "Process Doppelgänging";
            this.chkDoppelganging.UseVisualStyleBackColor = true;
            // 
            // chkManualMapping
            // 
            this.chkManualMapping.AutoSize = true;
            this.chkManualMapping.Location = new System.Drawing.Point(12, 43);
            this.chkManualMapping.Name = "chkManualMapping";
            this.chkManualMapping.Size = new System.Drawing.Size(105, 17);
            this.chkManualMapping.TabIndex = 2;
            this.chkManualMapping.Text = "Manual Mapping";
            this.chkManualMapping.UseVisualStyleBackColor = true;
            // 
            // chkReflectiveDLLInjection
            // 
            this.chkReflectiveDLLInjection.AutoSize = true;
            this.chkReflectiveDLLInjection.Location = new System.Drawing.Point(12, 22);
            this.chkReflectiveDLLInjection.Name = "chkReflectiveDLLInjection";
            this.chkReflectiveDLLInjection.Size = new System.Drawing.Size(140, 17);
            this.chkReflectiveDLLInjection.TabIndex = 1;
            this.chkReflectiveDLLInjection.Text = "Reflective DLL Injection";
            this.chkReflectiveDLLInjection.UseVisualStyleBackColor = true;
            // 
            // groupPS1
            // 
            this.groupPS1.Controls.Add(this.chkCLMBypass);
            this.groupPS1.Controls.Add(this.chkLoggingBypass);
            this.groupPS1.Controls.Add(this.chkConstraintedEscape);
            this.groupPS1.Controls.Add(this.chkAmsiPatchP);
            this.groupPS1.Location = new System.Drawing.Point(4, 88);
            this.groupPS1.Name = "groupPS1";
            this.groupPS1.Size = new System.Drawing.Size(395, 138);
            this.groupPS1.TabIndex = 9;
            this.groupPS1.TabStop = false;
            this.groupPS1.Text = "Stub Configuration | PowerShell Stub";
            // 
            // chkCLMBypass
            // 
            this.chkCLMBypass.AutoSize = true;
            this.chkCLMBypass.Location = new System.Drawing.Point(12, 88);
            this.chkCLMBypass.Name = "chkCLMBypass";
            this.chkCLMBypass.Size = new System.Drawing.Size(142, 17);
            this.chkCLMBypass.TabIndex = 4;
            this.chkCLMBypass.Text = "CLM/AppLocker Bypass";
            this.chkCLMBypass.UseVisualStyleBackColor = true;
            // 
            // chkLoggingBypass
            // 
            this.chkLoggingBypass.AutoSize = true;
            this.chkLoggingBypass.Location = new System.Drawing.Point(12, 65);
            this.chkLoggingBypass.Name = "chkLoggingBypass";
            this.chkLoggingBypass.Size = new System.Drawing.Size(101, 17);
            this.chkLoggingBypass.TabIndex = 3;
            this.chkLoggingBypass.Text = "Logging Bypass";
            this.chkLoggingBypass.UseVisualStyleBackColor = true;
            // 
            // chkConstraintedEscape
            // 
            this.chkConstraintedEscape.AutoSize = true;
            this.chkConstraintedEscape.Location = new System.Drawing.Point(12, 42);
            this.chkConstraintedEscape.Name = "chkConstraintedEscape";
            this.chkConstraintedEscape.Size = new System.Drawing.Size(202, 17);
            this.chkConstraintedEscape.TabIndex = 2;
            this.chkConstraintedEscape.Text = "Constrained Language Mode Escape";
            this.chkConstraintedEscape.UseVisualStyleBackColor = true;
            // 
            // chkAmsiPatchP
            // 
            this.chkAmsiPatchP.AutoSize = true;
            this.chkAmsiPatchP.Location = new System.Drawing.Point(12, 21);
            this.chkAmsiPatchP.Name = "chkAmsiPatchP";
            this.chkAmsiPatchP.Size = new System.Drawing.Size(79, 17);
            this.chkAmsiPatchP.TabIndex = 1;
            this.chkAmsiPatchP.Text = "Amsi Patch";
            this.chkAmsiPatchP.UseVisualStyleBackColor = true;
            // 
            // groupLogging
            // 
            this.groupLogging.Controls.Add(this.lstLogging);
            this.groupLogging.Location = new System.Drawing.Point(4, 232);
            this.groupLogging.Name = "groupLogging";
            this.groupLogging.Size = new System.Drawing.Size(395, 128);
            this.groupLogging.TabIndex = 10;
            this.groupLogging.TabStop = false;
            this.groupLogging.Text = "Stub Build Log | Logging";
            // 
            // lstLogging
            // 
            this.lstLogging.ContextMenuStrip = this.contextMenuStrip;
            this.lstLogging.FormattingEnabled = true;
            this.lstLogging.Location = new System.Drawing.Point(13, 21);
            this.lstLogging.Name = "lstLogging";
            this.lstLogging.Size = new System.Drawing.Size(367, 95);
            this.lstLogging.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem,
            this.toolStripSeparator1,
            this.debugTestToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(134, 54);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // debugTestToolStripMenuItem
            // 
            this.debugTestToolStripMenuItem.Name = "debugTestToolStripMenuItem";
            this.debugTestToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.debugTestToolStripMenuItem.Text = "Debug Test";
            this.debugTestToolStripMenuItem.Click += new System.EventHandler(this.debugTestToolStripMenuItem_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(4, 363);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(395, 36);
            this.btnBuild.TabIndex = 11;
            this.btnBuild.Text = "Build Stub";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(1, 404);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(69, 13);
            this.linkGitHub.TabIndex = 12;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "Noir\'s GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // linkLicense
            // 
            this.linkLicense.AutoSize = true;
            this.linkLicense.Location = new System.Drawing.Point(72, 404);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Size = new System.Drawing.Size(76, 13);
            this.linkLicense.TabIndex = 13;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "License && ToS";
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicense_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 424);
            this.Controls.Add(this.linkLicense);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.groupLogging);
            this.Controls.Add(this.groupStubConfig);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupDLL3);
            this.Controls.Add(this.groupDLL);
            this.Controls.Add(this.groupPS1);
            this.Controls.Add(this.groupDLL2);
            this.Name = "FrmMain";
            this.Text = "Runtime Reaper";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupStubConfig.ResumeLayout(false);
            this.groupStubConfig.PerformLayout();
            this.groupEXE.ResumeLayout(false);
            this.groupEXE.PerformLayout();
            this.groupDLL.ResumeLayout(false);
            this.groupDLL.PerformLayout();
            this.groupDLL2.ResumeLayout(false);
            this.groupDLL2.PerformLayout();
            this.groupDLL3.ResumeLayout(false);
            this.groupDLL3.PerformLayout();
            this.groupPS1.ResumeLayout(false);
            this.groupPS1.PerformLayout();
            this.groupLogging.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.GroupBox groupStubConfig;
        private System.Windows.Forms.CheckBox chkSaveChoice;
        private System.Windows.Forms.ComboBox comboOutputType;
        private System.Windows.Forms.GroupBox groupEXE;
        private System.Windows.Forms.CheckBox chkAmsiPatch;
        private System.Windows.Forms.CheckBox chkEtwBypass;
        private System.Windows.Forms.CheckBox chkCLRPatch;
        private System.Windows.Forms.CheckBox chkProcessInjection;
        private System.Windows.Forms.CheckBox chkAPIUnhooker;
        private System.Windows.Forms.CheckBox chkStackSpoofer;
        private System.Windows.Forms.ComboBox comboHollowing;
        private System.Windows.Forms.GroupBox groupDLL;
        private System.Windows.Forms.CheckBox chkApplicationWhitelist;
        private System.Windows.Forms.CheckBox chkTrustedProcessAbuse;
        private System.Windows.Forms.CheckBox chkDLLSearchOrder;
        private System.Windows.Forms.CheckBox chkInvalidCodeSig;
        private System.Windows.Forms.GroupBox groupDLL2;
        private System.Windows.Forms.CheckBox chkAppDomainMan;
        private System.Windows.Forms.CheckBox chkCLRHostBypass;
        private System.Windows.Forms.CheckBox chkAssemblyLoadTrigger;
        private System.Windows.Forms.CheckBox chkRegAsmAbuse;
        private System.Windows.Forms.GroupBox groupDLL3;
        private System.Windows.Forms.CheckBox chkReflectiveDLLInjection;
        private System.Windows.Forms.CheckBox chkManualMapping;
        private System.Windows.Forms.CheckBox chkDoppelganging;
        private System.Windows.Forms.CheckBox chkModuleStomping;
        private System.Windows.Forms.GroupBox groupPS1;
        private System.Windows.Forms.CheckBox chkAmsiPatchP;
        private System.Windows.Forms.CheckBox chkConstraintedEscape;
        private System.Windows.Forms.CheckBox chkLoggingBypass;
        private System.Windows.Forms.CheckBox chkCLMBypass;
        private System.Windows.Forms.GroupBox groupLogging;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.LinkLabel linkLicense;
        private System.Windows.Forms.ListBox lstLogging;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem debugTestToolStripMenuItem;
    }
}