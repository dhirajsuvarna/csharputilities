using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_workbench
{
    public partial class ResponseXMLViewer : Form
    {
        public ResponseXMLViewer()
        {
            InitializeComponent();
            CustomizeDataGridView();

        }

        private void CustomizeDataGridView()
        {
            this.xmlDataGridView.AllowUserToAddRows = false;
            this.xmlDataGridView.AllowUserToDeleteRows = false;
            this.xmlDataGridView.AutoGenerateColumns = true;


        }

        private void readButton_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML Files(*.xml)|*.xml";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;

                DataSet xmlDataSet = new DataSet();
                xmlDataSet.ReadXml(textBox1.Text);

                this.xmlDataGridView.DataSource = xmlDataSet;
            }
        }
    }
}
