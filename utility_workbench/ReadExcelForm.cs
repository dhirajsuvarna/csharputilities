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
        #region Constructor and Initializers
        public ReadExcelForm()
        {
            InitializeComponent();

            //BackgroundWorker Thread
            bwThread = new BackgroundWorker();
            bwThread.DoWork += new DoWorkEventHandler(processHeavyTask);
            bwThread.ProgressChanged += new ProgressChangedEventHandler(progressChanged);
            bwThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(heavyTaskCompleted);

            bwThread.WorkerReportsProgress = true;
            bwThread.WorkerSupportsCancellation = true;

            //Context Menu
            menuStrip = createContextMenuStrip();

            excelDataGridView.CellPainting += ExcelDataGridView_CellPainting;
            excelDataGridView.CellValueChanged += ExcelDataGridView_CellValueChanged;
            excelDataGridView.CurrentCellDirtyStateChanged += ExcelDataGridView_CurrentCellDirtyStateChanged;
            
        }


        private void PerformAutomation()
        {
            string isRegressionSystem = Environment.GetEnvironmentVariable("IsRegressionSystem", EnvironmentVariableTarget.User);
            if(isRegressionSystem.ToLower().Equals("yes"))
            {
                excuteButton.PerformClick();
            }
        }

        ContextMenuStrip menuStrip = null;
        private ContextMenuStrip createContextMenuStrip()
        {
            ToolStripMenuItem openFolderStripItem = new ToolStripMenuItem();
            openFolderStripItem.Text = "Open Containing Foler";
            openFolderStripItem.Click += new EventHandler(openFolderMenu_Click);

            ContextMenuStrip menuStrip = new ContextMenuStrip();
            menuStrip.Items.Add(openFolderStripItem);

            return menuStrip;
        }

        #endregion

        private void openFolderMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked me");
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

        #region Populate DataGridView
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

                AddCheckBoxColumn();
                AddStatusColumn();
                AddLinkColumn();
                AddButtonColumn();

                excelDataGridView.Columns["Part Name"].ContextMenuStrip = menuStrip;
                excelDataGridView.Columns["Links"].ContextMenuStrip = menuStrip;

                dataTable.TableName = "dhirajTable";
                dataTable.WriteXml(@"C:\Users\dhiraj\Documents\Visual Studio 2015\Projects\utility_workbench\files\xmldump.xml");

                PerformAutomation();

                //this should be done after databinding is done and the checkbox column is added
                foreach(DataGridViewRow thisRow in excelDataGridView.Rows)
                {
                    thisRow.Cells["SelectParts"].Value = true;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        #endregion

        #region Created Unbound Columns for DataGridView

        private void AddStatusColumn()
        {
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.HeaderText = "Status";
            textColumn.Name = "Status";

            int textColumnIndex = excelDataGridView.Columns["Part Name"].Index;
            excelDataGridView.Columns.Insert(textColumnIndex, textColumn);
        }

        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();

            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "SelectParts";
            //checkboxColumn.FlatStyle = FlatStyle.Standard;
            //checkboxColumn.TrueValue = true;
            checkboxColumn.ReadOnly = false;
            

            AddHeaderCheckBox();
            excelDataGridView.Columns.Insert(1, checkboxColumn);

        }

        private void AddButtonColumn()
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
            //linksColumn.ActiveLinkColor = Color.White;
            //linksColumn.LinkBehavior = LinkBehavior.SystemDefault;
            //linksColumn.LinkColor = Color.Blue;
            //linksColumn.TrackVisitedState = true;
            //linksColumn.VisitedLinkColor = Color.YellowGreen;
            //linksColumn.Text = "link";
            

            excelDataGridView.Columns.Insert(excelDataGridView.ColumnCount, linksColumn);
        }
        #endregion

        #region DataGridView Event Handlers
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
                MessageBox.Show("I am still not implemented, Please stop clicking ME!!!");
            }

        }

        private void excelDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (excelDataGridView.Columns[e.ColumnIndex].Name.Equals("Links"))
            {
                if (e.Value != null)
                {
                    string fullPathofFile = e.Value.ToString();
                    e.Value = Path.GetFileName(fullPathofFile); //change the display name for Hyperlink
                    DataGridViewCell thisCell = excelDataGridView[e.ColumnIndex, e.RowIndex];
                    thisCell.ToolTipText = fullPathofFile;
                   
                }
            }
        }

        #endregion

        #region Implementation of Search Text Box
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = (excelDataGridView.DataSource as DataView);
            string newStr = string.Format("[Part Name] LIKE '%{0}%'", searchTextBox.Text);
            dataView.RowFilter = newStr;
        }
        #endregion

        #region Execution of Process

        BackgroundWorker bwThread = null;
        Stopwatch stopWatch = new Stopwatch();
        private void excuteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = excelDataGridView.Rows;
            stopWatch.Start();
            timer1.Start();
            bwThread.RunWorkerAsync(rows); //execute task in background thread

            TimeSpan timeSpan = stopWatch.Elapsed;


        }

        private void heavyTaskCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopWatch.Stop();
            timer1.Stop();
        }

        private void progressChanged(object sender, ProgressChangedEventArgs e)
        {
            //MessageBox.Show(e.ProgressPercentage.ToString());

            DataGridViewRow row = e.UserState as DataGridViewRow;

            string fileName = row.Cells["Part Name"].Value.ToString() + ".txt";
            string[] files = Directory.GetFiles(@"C:\Users\dhiraj\Documents\Visual Studio 2015\Projects\utility_workbench\dump", fileName);
            if (files.Length > 0)
            {
                row.Cells["Links"].Value = files[0];
                row.Cells["Status"].Value = "Completed";
                excelDataGridView.Update();
                excelDataGridView.Refresh();
            }
        }

        private void processHeavyTask(object sender, DoWorkEventArgs e)
        {
            DataGridViewRowCollection rows = e.Argument as DataGridViewRowCollection;

            foreach (DataGridViewRow row in rows)
            {
                row.Selected = true;
                row.Cells["Status"].Value = "In Progress...";

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

                int percentageCompleted = (int)((((float)row.Index + 1) / rows.Count) * 100);
                bwThread.ReportProgress(percentageCompleted, row);

                //MessageBox.Show(percentageCompleted.ToString());
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        #region CREATING CHECKBOX COLUMN WITH CHECKBOX HEADER

        CheckBox headerCheckBox = null;
        private void AddHeaderCheckBox()
        {
            headerCheckBox = new CheckBox();
            headerCheckBox.ThreeState = true;
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.CheckState = CheckState.Checked;

            headerCheckBox.Click += HeaderCheckBox_Click;
            excelDataGridView.Controls.Add(headerCheckBox);
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.excelDataGridView.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - headerCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - headerCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            headerCheckBox.Location = oPoint;
        }

        private void ExcelDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (headerCheckBox != null & (e.ColumnIndex == 1 && e.RowIndex == -1))
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            if(headerCheckBox.CheckState == CheckState.Checked)
            {
                foreach (DataGridViewRow thisRow in excelDataGridView.Rows)
                {
                    thisRow.Cells["SelectParts"].Value = true;
                }
            }
            else if(headerCheckBox.CheckState == CheckState.Unchecked)
            {
                foreach (DataGridViewRow thisRow in excelDataGridView.Rows)
                {
                    thisRow.Cells["SelectParts"].Value = false;
                }
            }
            else if (headerCheckBox.CheckState == CheckState.Indeterminate)
            {
                headerCheckBox.CheckState = CheckState.Unchecked;
                foreach (DataGridViewRow thisRow in excelDataGridView.Rows)
                {
                    thisRow.Cells["SelectParts"].Value = false;
                }
            }

            excelDataGridView.RefreshEdit();
        }
        private void ExcelDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (excelDataGridView.CurrentCell is DataGridViewCheckBoxCell)
            {
                excelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void ExcelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (excelDataGridView.Columns[e.ColumnIndex].Name.Equals("SelectParts"))
            {
                int numofCheckCount = (from row in excelDataGridView.Rows.Cast<DataGridViewRow>()
                                       where row.Cells["SelectParts"].Value != null &&
                                       (bool)row.Cells["SelectParts"].Value == true
                                       select row).Count();

                if (numofCheckCount == excelDataGridView.RowCount)
                {
                    headerCheckBox.CheckState = CheckState.Checked;
                }
                else if (numofCheckCount == 0)
                {
                    headerCheckBox.CheckState = CheckState.Unchecked;
                }
                else
                {
                    headerCheckBox.CheckState = CheckState.Indeterminate;
                }
            }
        }


        #endregion
    }
}
