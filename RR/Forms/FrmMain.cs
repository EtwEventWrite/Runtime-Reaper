/*
 * Coded by @Noir,
 * License is MIT if you did not read it meaning yes you can skid this and re-sell it or what not
 * you do just need to credit me, if you do not I will take it down and shame you.
 * If you do you get kudos :p
 * 
 * Anyways thats bout it folks, Enjoy!
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RR.DarkMode;

namespace RR.Forms
{
    public partial class FrmMain : Form
    {
        public enum OutputType
        {
            EXE_Native,
            EXE_Sideload,
            DLL_NET,
            DLL_Native,
            PowerShell
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (chkSaveChoice.Checked)
            {

            }
        }

        private OutputType GetSelectedOutputType()
        {
            string selected = comboOutputType.SelectedItem?.ToString() ?? "";
            if (selected.Contains("Windows Executable")) return OutputType.EXE_Native;
            if (selected.Contains("DLL Sideloading")) return OutputType.EXE_Sideload;
            if (selected.Contains(".NET")) return OutputType.DLL_NET;
            if (selected.Contains("Native")) return OutputType.DLL_Native;
            if (selected.Contains("PowerShell")) return OutputType.PowerShell;
            return OutputType.EXE_Native;
        }

        private void UpdateOutputSelectionType()
        {
            groupEXE.Visible = false;
            groupDLL.Visible = false;
            groupDLL2.Visible = false;
            groupDLL3.Visible = false;
            groupPS1.Visible = false;
            OutputType selectedType = GetSelectedOutputType();
            switch (selectedType)
            {
                case OutputType.EXE_Native:
                    groupEXE.Visible = true;
                    groupEXE.BringToFront();
                    break;
                case OutputType.EXE_Sideload:
                    groupDLL.Visible = true;
                    groupDLL.BringToFront();
                    break;
                case OutputType.DLL_NET:
                    groupDLL2.Visible = true;
                    groupDLL2.BringToFront();
                    break;
                case OutputType.DLL_Native:
                    groupDLL3.Visible = true;
                    groupDLL3.BringToFront();
                    break;
                case OutputType.PowerShell:
                    groupPS1.Visible = true;
                    groupPS1.BringToFront();
                    break;
                default:
                    groupEXE.Visible = true;
                    groupEXE.BringToFront();
                    break;
            }
        }

        private void comboOutputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOutputSelectionType();
        }

        private void debugTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            lstLogging.Items.Add(@"[DEBUG] ListBox is Working.");
            lstLogging.Items.Add(@"[DEBUG] Blah Blah Blah");
            lstLogging.Items.Add(@"[DEBUG] Important Information.");
#endif
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLogging.Items.Clear();
        }

        private void chkProcessInjection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcessInjection.Checked)
            {
                comboHollowing.Enabled = true;
            }
            else
            {
                comboHollowing.Enabled = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files (*.exe)|*.exe";
                ofd.Title = "Select EXE to crypt";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = ofd.FileName;
                }
#if DEBUG
                lstLogging.Items.Add(@"[DEBUG] Selected EXE, OK.");
#endif
            }
        }
    }
}
