using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_postgres
{
    internal class Exceles
    {
       public void SaveExcel(DataGridView data,string filename)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + filename;
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excelapp.Workbooks.Add();
          // Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet();
            excelapp.Columns.ColumnWidth = 20;
            excelapp.Rows.Font.Name = "Arial";
            excelapp.StandardFontSize = 12;
            excelapp.Columns.AutoFit();
            for (int k = 0; k <= data.Columns.Count - 1; k++)
            {
                excelapp.Cells[k + 1].Value = data.Columns[k].HeaderCell.Value;
            }
            for (int i = 1; i < data.RowCount + 1; i++)
            {
                for (int j = 1; j < data.ColumnCount + 1; j++)
                {
                    excelapp.Rows[i + 1].Columns[j] = data.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            workbook.SaveAs(path);
            //excelapp.AlertBeforeOverwriting = false;
            //workbook.SaveAs(path);
            //MessageBox.Show("Данные успешно сохранены");
            //excelapp.Workbooks.Open(path);
            //excelapp.Quit();
        }
        public void SaveExcelOne(DataGridView data, string filename)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + filename;
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excelapp.Workbooks.Add();
            excelapp.Columns.ColumnWidth = 20;
            excelapp.Rows.Font.Name = "Arial";
            excelapp.StandardFontSize = 12;
            excelapp.Columns.AutoFit();
            if (data.SelectedRows.Count != 0)
            {
                for (int i = 1; i < data.Columns.Count + 1; i++)
                {
                    excelapp.Cells[1, i] = data.Columns[i - 1].HeaderText;
                }

                int rowIndex = 2;
                foreach (DataGridViewRow r in data.SelectedRows)
                {
                    for (int j = 0; j < r.Cells.Count; j++)
                    {
                        excelapp.Cells[rowIndex, j + 1] = r.Cells[j].Value.ToString();
                    }

                    rowIndex++;
                }   
            }
            workbook.SaveAs(path);
        }
    }
}
