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

namespace utility_workbench
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/c time /t";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;

            if (proc.Start())
            {
                string output = proc.StandardOutput.ReadToEnd();
                MessageBox.Show(output);
                //The /c used in argument of the cmd.exe process exits the command line process and hence
                //closing of process is not required.
            }
            else
            {
                MessageBox.Show("Process Not Started");
            }
            
        }

        private void extractZipButton_Click(object sender, EventArgs e)
        {
            ExtractZipForm extractZipForm = new ExtractZipForm();
            extractZipForm.ShowDialog();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            ExcelUtilityForm excelUtilForm = new ExcelUtilityForm();
            excelUtilForm.ShowDialog();
        }

        private void writeExcelButton_Click(object sender, EventArgs e)
        {
            WriteExcelForm writeExcelForm = new WriteExcelForm();
            writeExcelForm.ShowDialog();
        }
    }
}
