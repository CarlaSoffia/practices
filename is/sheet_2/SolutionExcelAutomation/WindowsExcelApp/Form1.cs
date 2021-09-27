using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel_Lib;

namespace WindowsExcelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateNewFile_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            ExcelHandler.createNewExcelfile(fileName);

            MessageBox.Show($"File {fileName} created");
        }

        private void buttonWriteExcelFile_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            ExcelHandler.WriteToExcelFile(fileName);

            MessageBox.Show($"Wrote to File {fileName}");
        }

        private void buttonReadExcelFile_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            string content = ExcelHandler.ReadFromExcelFile(fileName);
            textBoxContent.Text = content;
        }

        private void buttonCreateChart_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            ExcelHandler.chartCreate(fileName);
            MessageBox.Show($"Graph created in File {fileName}");
        }

        private void buttonReadNMCells_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            if (textBoxColumns.Text == "")
            {
                MessageBox.Show("Number of columns is not filled");
                return;
            }

            if (textBoxStartLine.Text == "")
            {
                MessageBox.Show("Number of Lines is not filled");
                return;
            }

            if (textBoxStartLine.Text == "")
            {
                MessageBox.Show("Start Line is not filled");
                return;
            }

            if (textBoxStartCol.Text == "")
            {
                MessageBox.Show("Start Column is not filled");
                return;

            }

            int cols = Convert.ToInt32(textBoxColumns.Text);
            int lines = Convert.ToInt32(textBoxLines.Text);
            int startCol = Convert.ToInt32(textBoxStartCol.Text);
            int startLine = Convert.ToInt32(textBoxStartLine.Text);

            if (cols <= 0)
            {
                MessageBox.Show("Number of Columns is invalid");
                return;
            }

            if (lines <= 0)
            {
                MessageBox.Show("Number of Lines is invalid");
                return;
            }

            if (startCol <= 0)
            {
                MessageBox.Show("Start Column is invalid");
                return;
            }

            if (startLine <= 0)
            {
                MessageBox.Show("Start Line is invalid");
                return;
            }

            string content = ExcelHandler.readNMCells(fileName, cols, lines, startCol, startLine);

            textBoxContentCells.Text = content;
        }

        private void btnReadWorksheet_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            if (textBoxWorksheetName.Text == "")
            {
                MessageBox.Show("Worksheet Name is not filled");
                return;
            }

            string content = ExcelHandler.readContentWorksheet(fileName, textBoxWorksheetName.Text);
            textBoxWorksheetContent.Text = content;
        }

        private void btnWriteWorksheet_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            string content = textBoxWriteContent.Text; 
            if (content == "")
            {
                MessageBox.Show("Nothing was written");
                return;
            }

            ExcelHandler.writeContentWorksheet(fileName, content);
            MessageBox.Show($"Wrote {content} to {fileName}");
        }

        private void btnUsedLines_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            int usedLines = ExcelHandler.usedLinesWorksheet(fileName);
            textBoxUsedLines.Text = usedLines.ToString();
        }

        private void btnFindString_Click(object sender, EventArgs e)
        {
            string fileName = "Sheet2_Excel_file.xlsx";
            string stringFind = textBoxStringFind.Text;
            if (stringFind == "")
            {
                MessageBox.Show("String to find in the worksheet is empty");
            }
            
            switch(ExcelHandler.findString(fileName, stringFind))
            {
                case true:
                    MessageBox.Show($"{stringFind} was found in the worksheet");
                    break;
                default:
                    MessageBox.Show($"{stringFind} was NOT found in the worksheet");
                    break;
            }
        }
    }
}
