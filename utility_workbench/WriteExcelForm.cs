using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace utility_workbench
{
    public partial class WriteExcelForm : Form
    {
        public WriteExcelForm()
        {
            InitializeComponent();
        }

        private void writeExcelButton_Click(object sender, EventArgs e)
        {
            //Closing excel.exe elegently is a huge problem. If the COM objects are not cleared properly, excel.exe
            //stays running in the task manager.
            //the link here describes various methods to solve this problem.
            //https://stackoverflow.com/questions/158706/how-do-i-properly-clean-up-excel-interop-objects/158752#158752  
            //Please go through all the answers and not just the accepted answer.

            //Infact I found out that the behaviour of the GC is different in Debug and Release mode 
            //in this answer https://stackoverflow.com/a/1893653/2241802 

            //Also this answer refers to the more practical way of how we can implement the excel objects without 
            //creating reference for each object and later releasing it is described in this answer
            //https://stackoverflow.com/a/159419/2241802

            try
            {
                WriteExcel();
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void WriteExcel()
        {
            Excel.Application xlApp = null;
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not installed!!!");
                    return;
                }

                //Excel.Workbooks xlWorkBooks = xlApp.Workbooks;
                //Excel.Workbook xlWorkBook = xlWorkBooks.Add(Type.Missing);
                xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
                xlWorkSheet = xlWorkBook.ActiveSheet;
                xlWorkSheet.Name = "sample";


                //xlWorkSheet.Cells[1, 1] = "dhiraj";
                Excel.Range range1 = xlWorkSheet.Cells[1, 1];
                range1.Value = "dhiraj";

                Excel.Range range2 = xlWorkSheet.Range["A2"];
                range2.Value = "suvarna";
                //range2.Font.Bold;

                xlWorkBook.SaveAs("C:\\Users\\dhiraj\\Documents\\Visual Studio 2015\\Projects\\utility_workbench\\output.xlsx");
            }
            finally
            {
                xlWorkBook.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();

                //Marshal.FinalReleaseComObject(range1);
                //Marshal.FinalReleaseComObject(range2);
                Marshal.FinalReleaseComObject(xlWorkSheet);
                Marshal.FinalReleaseComObject(xlWorkBook);
                //Marshal.FinalReleaseComObject(xlWorkBooks);
                Marshal.FinalReleaseComObject(xlApp);

            }
        }
    }
}
