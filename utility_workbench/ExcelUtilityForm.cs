using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_workbench
{
    public partial class ExcelUtilityForm : Form
    {
        public ExcelUtilityForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Excel File";
            fileDialog.Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx";

            if(fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                excelPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void readExcel_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelPathTextBox.Text +"; Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'");
            connection.Open();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from [sheet1$]", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            excelDataGridView.DataSource = dataTable.DefaultView;
        }
    }
}
