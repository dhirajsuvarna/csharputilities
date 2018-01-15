using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_workbench
{
    public partial class CopyExampleForm : Form
    {
        public CopyExampleForm()
        {
            InitializeComponent();
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBorwse = new FolderBrowserDialog();
            if(folderBorwse.ShowDialog() == DialogResult.OK)
            {
                sourceTextBox.Text = folderBorwse.SelectedPath;
            }
        }

        private void browseDestinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            if(folderBrowse.ShowDialog() == DialogResult.OK)
            {
                destinationTextBox.Text = folderBrowse.SelectedPath;
            }
        }

        private void startCopyButton_Click(object sender, EventArgs e)
        {
            var files = Directory.EnumerateFiles(sourceTextBox.Text, "*.*", SearchOption.AllDirectories).Where(s => s.ToLower().EndsWith(".txt") || s.ToLower().EndsWith(".xml"));
            
            foreach(string thisFile in files)
            {
                string destinationFile = thisFile.Replace(sourceTextBox.Text, destinationTextBox.Text);
                Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));

                File.Copy(thisFile, destinationFile, true);
            }
        }
    }
}
