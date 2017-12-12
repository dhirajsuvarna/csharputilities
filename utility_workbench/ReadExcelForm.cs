using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_workbench
{
    public partial class ReadExcelForm : Form
    {
        BackgroundWorker bwThread = null;

        public ReadExcelForm()
        {
            InitializeComponent();
            bwThread = new BackgroundWorker();
            bwThread.DoWork += new DoWorkEventHandler(processHeavyTask);
            bwThread.ProgressChanged += new ProgressChangedEventHandler(progressChanged);
            bwThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(heavyTaskCompleted);

            bwThread.WorkerReportsProgress = true;
            bwThread.WorkerSupportsCancellation = true;
        }

        private void heavyTaskCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void processHeavyTask(object sender, DoWorkEventArgs e)
        {
            DataGridViewRow row = e.Argument as DataGridViewRow;
            if(row != null)
            {

            }
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
            try
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPathTextBox.Text + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                //OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelPathTextBox.Text + ";Extended Properties='Excel 8.0; HDR = Yes; IMEX = 1'");
                connection.Open();

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from [sheet1$]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                excelDataGridView.DataSource = dataTable.DefaultView;

                AddLinkColumn();
                CreateUnboundButtonColumn();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void CreateUnboundButtonColumn()
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Compare";
            buttonColumn.HeaderText = "Compare";
            buttonColumn.Text = "Compare";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            excelDataGridView.Columns.Insert(excelDataGridView.ColumnCount, buttonColumn);
        }
        private void AddLinkColumn()
        {
            DataGridViewLinkColumn linksColumn = new DataGridViewLinkColumn();

            linksColumn.UseColumnTextForLinkValue = false;
            linksColumn.Name = "Links";
            linksColumn.HeaderText = "Links";
            //links.DataPropertyName = ColumnName.ReportsTo.ToString();
            linksColumn.ActiveLinkColor = Color.White;
            linksColumn.LinkBehavior = LinkBehavior.SystemDefault;
            linksColumn.LinkColor = Color.Blue;
            linksColumn.TrackVisitedState = true;
            linksColumn.VisitedLinkColor = Color.YellowGreen;
            //linksColumn.Text = "link";

            excelDataGridView.Columns.Insert(excelDataGridView.ColumnCount, linksColumn);
        }

        private void excuteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = excelDataGridView.Rows;

            foreach (DataGridViewRow row in rows)
            {
                bwThread.RunWorkerAsync(row);

                excelDataGridView.Rows[row.Index].Selected = true;

                string partName = row.Cells["Part Name"].Value.ToString();
                string process = row.Cells["Process"].Value.ToString();
                string quantity = row.Cells["Quantity"].Value.ToString();
                string plant = row.Cells["Plant"].Value.ToString();
                string materialFamily = row.Cells["Material Family"].Value.ToString();
                string materialGrade = row.Cells["Material Grade"].Value.ToString();

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                while (stopWatch.Elapsed < TimeSpan.FromSeconds(5))
                {
                }
                stopWatch.Stop();

                string fileName = partName + ".txt";
                string[] lines = { partName, process, quantity, plant, materialFamily, materialGrade };
                File.WriteAllLines(@"C:\Users\dhiraj\Documents\Visual Studio 2015\Projects\utility_workbench\dump\" + fileName, lines);

                string [] files = Directory.GetFiles(@"C:\Users\dhiraj\Documents\Visual Studio 2015\Projects\utility_workbench\dump", fileName);
                if (files.Length > 0)
                {
                    row.Cells["Links"].Value = files[0];
                    excelDataGridView.Update();
                    excelDataGridView.Refresh();
                }
            }
        }

        private void excelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == excelDataGridView.Columns["Links"].Index) //Handling of HyperLink Click
            {
                string cellValue = excelDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //MessageBox.Show(cellValue);
                Process.Start(cellValue);
            }
            if(excelDataGridView.Columns[e.ColumnIndex].Name.Equals("Compare"))
            {
                MessageBox.Show("I have am still not implemented, Please stop clicking ME!!!");
            }
        }

        private void excelDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (excelDataGridView.Columns[e.ColumnIndex].Name.Equals("Links"))
            {
                if(e.Value != null)
                    e.Value = Path.GetFileName(e.Value.ToString()); //change the display name for Hyperlink
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = (excelDataGridView.DataSource as DataView);
            string newStr = string.Format("[Part Name] LIKE '%{0}%'", searchTextBox.Text);
            dataView.RowFilter = newStr;
        }
    }
}
