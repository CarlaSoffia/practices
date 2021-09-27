using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Lib
{
    public class ExcelHandler
    {
        public static void createNewExcelfile(string filename)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = true;

            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Add();
            excelWorkbook.SaveAs(filename, AccessMode: Excel.XlSaveAsAccessMode.xlNoChange);

            excelWorkbook.Close();
            excelApplication.Quit();

            //libertar memoria
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();
        }

        private static void MyReleaseCOMObject(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                System.Diagnostics.Debug.WriteLine($"Erro: {ex.Message}");
            }
        }

        public static void WriteToExcelFile(string filename)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = true;

            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(filename);
            Excel.Worksheet excelWorksheet = excelWorkbook.ActiveSheet;

            excelWorksheet.Cells[1, 1].Value = "Hello";
            excelWorksheet.Cells[1, 2].Value = "World!";

            Excel.Worksheet excelWorksheet2 = excelWorkbook.Worksheets.Add();
            excelWorksheet2.Cells[1, 1].Value = "Goodbye";
            excelWorksheet2.Cells[1, 2].Value = "World!";

            excelWorksheet2.Cells[4, 2].Value = "Nome";
            excelWorksheet2.Cells[5, 2].Value = "Ana";
            excelWorksheet2.Cells[6, 2].Value = "Pedro";
            excelWorksheet2.Cells[7, 2].Value = "Rui";
            excelWorksheet2.Cells[8, 2].Value = "Abel";
            excelWorksheet2.Cells[9, 2].Value = "Filipa";

            excelWorksheet2.Cells[4, 3].Value = "Idade";
            excelWorksheet2.Cells[5, 3].Value = "19";
            excelWorksheet2.Cells[6, 3].Value = "18";
            excelWorksheet2.Cells[7, 3].Value = "21";
            excelWorksheet2.Cells[8, 3].Value = "20";
            excelWorksheet2.Cells[9, 3].Value = "18";

            excelWorkbook.Save();
            excelWorkbook.Close();
            excelApplication.Quit();


            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorksheet2);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();
        }

        public static string ReadFromExcelFile(string fileName)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Worksheet excelWorksheet = excelWorkbook.ActiveSheet;

            string content = excelWorksheet.Cells[1, 1].Value;
            content += " " + (excelWorksheet.Cells[1, 2] as Excel.Range).Text;

            excelWorkbook.Close();
            excelApplication.Quit();
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();

            return content;
        }

        public static void chartCreate(string fileName)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Worksheet excelWorksheet = excelWorkbook.ActiveSheet;

            Excel.Chart chart = null;
            Excel.ChartObjects chartObjs = excelWorksheet.ChartObjects();
            Excel.ChartObject objChart = chartObjs.Add(150, 150, 300, 300);
            chart = objChart.Chart;

            Excel.Range range = excelWorksheet.get_Range("B5:C9");
            chart.SetSourceData(range);
            chart.ChartColor = 25;
            chart.ChartType = Excel.XlChartType.xl3DBarClustered;
            
                
            chart.ChartWizard(
                Source: range,
                Title: "Name/Age",
                CategoryTitle: "Name",
                ValueTitle: "Age"
                );

            excelWorkbook.Save();
            excelWorkbook.Close();
            excelApplication.Quit();

            MyReleaseCOMObject(range);
            MyReleaseCOMObject(objChart);
            MyReleaseCOMObject(chartObjs);
            MyReleaseCOMObject(chart);
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();
        }

        public static string readNMCells(string fileName, int cols, int lines, int startCol, int startLine)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

            string content = "";
            int maxLines = lines + startLine;
            int maxCols = cols + startCol;
            for (int i = startLine; i < maxLines; i++)
            {
                for (int j = startCol; j < maxCols; j++)
                {
                    content += $"[ Cells {i}|{j}] -> " + (excelWorksheet.Cells[i, j] as Excel.Range).Text + Environment.NewLine;
                }
            }
            excelWorkbook.Close();
            excelApplication.Quit();
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();

            return content;
        }

        public static string readContentWorksheet(string fileName, string workSheetName) {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Sheets sheets = excelWorkbook.Worksheets;

            Excel.Worksheet worksheet = null;
            Boolean found = false;
            for (int i = 1; i <= sheets.Count; i++)
            {
                worksheet = (Excel.Worksheet)sheets.get_Item(i);
                if (worksheet.Name.Equals(workSheetName))
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                throw new Exception("Worksheet not found");
            }
            string content = "";
            foreach (Excel.Range cell in worksheet.UsedRange)
            {
                content += $"{cell.Text} ";
            }
            excelWorkbook.Close();
            excelApplication.Quit();
            MyReleaseCOMObject(worksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();
            return content;

        }

        public static void writeContentWorksheet(string fileName, string content)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Sheets sheets = excelWorkbook.Worksheets;
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)sheets.get_Item(2);

            excelWorksheet.Cells[1, 1].Value = content;

            excelWorkbook.Save();
            excelWorkbook.Close();
            excelApplication.Quit();
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();
        }

        public static int usedLinesWorksheet(string fileName)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Sheets sheets = excelWorkbook.Worksheets;
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)sheets.get_Item(1);

            Excel.Range range = excelWorksheet.UsedRange; 
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            string content = "";
            int usedRows = 0;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    content += (range.Cells[i, j] as Excel.Range).Value2;
                }
                if (!content.Equals(""))
                {
                    usedRows++;
                }
                content = "";
            }
            excelApplication.Quit();
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();

            return usedRows;
        }

        public static Boolean findString(string fileName, string content)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(fileName);
            Excel.Sheets sheets = excelWorkbook.Worksheets;
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)sheets.get_Item(1);

            Excel.Range range = excelWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            Boolean foundString = false;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (((range.Cells[i, j] as Excel.Range).Text) == content)
                    {
                        foundString = true;
                    }
                }
                if (foundString)
                {
                    break;
                }
               
            }

            excelApplication.Quit();
            MyReleaseCOMObject(excelWorksheet);
            MyReleaseCOMObject(excelWorkbook);
            MyReleaseCOMObject(excelApplication);
            GC.Collect();

            return foundString;
        } 

    }
}
