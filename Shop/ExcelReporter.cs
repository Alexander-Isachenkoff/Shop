using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    class ExcelReporter
    {
        public void ShowExcelReport(DataGridView dg)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            int col_n = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                if (column.Visible)
                {
                    excelApp.Cells[1, col_n + 1] = column.HeaderText;
                    col_n++;
                }
            }

            for (int i = 0; i < dg.Rows.Count; i++)
            {
                col_n = 0;
                foreach (DataGridViewColumn column in dg.Columns)
                {
                    if (column.Visible)
                    {
                        excelApp.Cells[i + 2, col_n + 1] = dg.Rows[i].Cells[col_n].Value;
                        col_n++;
                    }
                }
            }

            excelApp.Visible = true;
        }
    }
}
