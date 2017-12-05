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
    public partial class ExtractZipForm : Form
    {
        public ExtractZipForm()
        {
            InitializeComponent();
        }

        private void zipFileBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Zip Files |*.7z;*.zip;*.exe";
            fileDialog.Title = "Select a Zip File";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ZipFileTextBox.Text = fileDialog.FileName; 
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/c 7z.exe x " + ZipFileTextBox.Text + " -o* -y";
            proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(ZipFileTextBox.Text);
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.EnvironmentVariables["PATH"] = System.Environment.GetEnvironmentVariable("PATH") + ";C:\\Program Files\\7-Zip";
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;

            if(proc.Start())
                OutputTextBox.AppendText(proc.StandardOutput.ReadToEnd());


        }
    }
}
