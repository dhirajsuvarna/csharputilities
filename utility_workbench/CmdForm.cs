using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace utility_workbench
{
    public partial class CmdForm : Form
    {
        private StringBuilder output = new StringBuilder();

        public CmdForm()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";

            Process proc = new Process();
            proc.StartInfo.FileName = "robocopy.exe";
            proc.StartInfo.Arguments = @"E:\Movies\English\720p\Titanic.1997.720p.Dual.Audio{English-Hindi}BRRip.aaaevilacharya G:\9 Titanic.720p.Dual.Audio{English-Hindi}BRRip.aaaevilacharya_en.srtt";
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.SynchronizingObject = this;
            proc.OutputDataReceived += Proc_OutputDataReceived;
            proc.ErrorDataReceived += Proc_OutputDataReceived;

            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            //proc.WaitForExit();
            //int exitCode = proc.ExitCode;
            proc.Close();
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                outputRichTextBox.Text += e.Data + "\r\n";
                Console.Write(e.Data);
            }
        }


    }
}
