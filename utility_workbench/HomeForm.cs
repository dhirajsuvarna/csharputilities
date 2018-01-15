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

        private void viewSettingsButton_Click(object sender, EventArgs e)
        {
            ViewSettings settingsForm = new ViewSettings();
            settingsForm.Show();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            SendMailForm sendMailForm = new SendMailForm();
            sendMailForm.Show();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            CopyExampleForm copyExample = new CopyExampleForm();
            copyExample.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropertyGridSampleFrom propertyGridSampleForm = new PropertyGridSampleFrom();
            propertyGridSampleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResponseXMLViewer responseXMLViewer = new ResponseXMLViewer();
            responseXMLViewer.ShowDialog();
        }
    }
}
