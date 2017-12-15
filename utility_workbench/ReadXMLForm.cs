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
    public partial class ReadXMLForm : Form
    {
        public ReadXMLForm()
        {
            InitializeComponent();
            tableDataGridView.AllowUserToAddRows = false;
            tableDataGridView.AllowUserToDeleteRows = false;
            tableDataGridView.ReadOnly = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "*.xml (XML Files) | *.xml";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFileTextBox.Text = fileDialog.FileName;
            }
        }

        DataSet requestSet = null;
        private void readButton_Click(object sender, EventArgs e)
        {
            requestSet = new DataSet();

            requestSet.ReadXml(xmlFileTextBox.Text);

            List<string> tableNameList = new List<string>();
            foreach (DataTable table in requestSet.Tables)
            {
                tableNameList.Add(table.TableName);
            }

            tableNamecomboBox.DataSource = tableNameList;
        }

        private void tableNamecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tableNamecomboBox.SelectedItem.ToString());
            DataTable selectedTable = requestSet.Tables[tableNamecomboBox.SelectedItem.ToString()];
            tableDataGridView.DataSource = selectedTable;

        }
    }
}
