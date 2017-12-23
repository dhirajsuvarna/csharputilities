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
            CmdForm cmdForm = new CmdForm();
            cmdForm.ShowDialog();

            //Process proc = new Process();
            //proc.StartInfo.FileName = "cmd.exe";
            ////proc.StartInfo.Arguments = "/c time /t";
            //proc.StartInfo.Arguments = @"/c robocopy E:\Movies\English\720p\Titanic.1997.720p.Dual.Audio{English-Hindi}BRRip.aaaevilacharya G:\ Titanic.720p.Dual.Audio{English-Hindi}BRRip.aaaevilacharya.mkv";
            //proc.StartInfo.UseShellExecute = false;
            //proc.StartInfo.RedirectStandardOutput = true;
            //proc.StartInfo.CreateNoWindow = true;
            //proc.OutputDataReceived += Proc_OutputDataReceived;

            //if (proc.Start())
            //{
            //    string output = proc.StandardOutput.ReadToEnd();
            //    MessageBox.Show(output);
            //    //The /c used in argument of the cmd.exe process exits the command line process and hence
            //    //closing of process is not required.
            //}
            //else
            //{
            //    MessageBox.Show("Process Not Started");
            //}
            
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            
        }

        private void extractZipButton_Click(object sender, EventArgs e)
        {
            ExtractZipForm extractZipForm = new ExtractZipForm();
            extractZipForm.ShowDialog();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            ReadExcelForm excelUtilForm = new ReadExcelForm();
            excelUtilForm.ShowDialog();
        }

        private void writeExcelButton_Click(object sender, EventArgs e)
        {
            WriteExcelForm writeExcelForm = new WriteExcelForm();
            writeExcelForm.ShowDialog();
        }

        private void dataGridViewButton_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm();
            dataGridViewForm.ShowDialog();
        }

        private void readXMLButton_Click(object sender, EventArgs e)
        {
            ReadXMLForm xmlForm = new ReadXMLForm();
            xmlForm.ShowDialog();
        }

        private void log4netButton_Click(object sender, EventArgs e)
        {
            Log4NetSample logForm = new Log4NetSample();
            logForm.ShowDialog();
        }
    }
}
