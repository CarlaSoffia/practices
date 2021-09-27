
namespace WindowsExcelApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateNewFile = new System.Windows.Forms.Button();
            this.buttonWriteExcelFile = new System.Windows.Forms.Button();
            this.buttonReadExcelFile = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonCreateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReadNMCells = new System.Windows.Forms.Button();
            this.textBoxStartLine = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContentCells = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStartCol = new System.Windows.Forms.TextBox();
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.textBoxWorksheetContent = new System.Windows.Forms.TextBox();
            this.btnReadWorksheet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWorksheetName = new System.Windows.Forms.TextBox();
            this.textBoxWriteContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWriteWorksheet = new System.Windows.Forms.Button();
            this.textBoxUsedLines = new System.Windows.Forms.TextBox();
            this.btnUsedLines = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStringFind = new System.Windows.Forms.TextBox();
            this.btnFindString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNewFile
            // 
            this.buttonCreateNewFile.Location = new System.Drawing.Point(12, 57);
            this.buttonCreateNewFile.Name = "buttonCreateNewFile";
            this.buttonCreateNewFile.Size = new System.Drawing.Size(174, 37);
            this.buttonCreateNewFile.TabIndex = 0;
            this.buttonCreateNewFile.Text = "1.3 - Create New File";
            this.buttonCreateNewFile.UseVisualStyleBackColor = true;
            this.buttonCreateNewFile.Click += new System.EventHandler(this.buttonCreateNewFile_Click);
            // 
            // buttonWriteExcelFile
            // 
            this.buttonWriteExcelFile.Location = new System.Drawing.Point(192, 58);
            this.buttonWriteExcelFile.Name = "buttonWriteExcelFile";
            this.buttonWriteExcelFile.Size = new System.Drawing.Size(191, 38);
            this.buttonWriteExcelFile.TabIndex = 1;
            this.buttonWriteExcelFile.Text = "1.4 - Write To Excel File";
            this.buttonWriteExcelFile.UseVisualStyleBackColor = true;
            this.buttonWriteExcelFile.Click += new System.EventHandler(this.buttonWriteExcelFile_Click);
            // 
            // buttonReadExcelFile
            // 
            this.buttonReadExcelFile.Location = new System.Drawing.Point(12, 163);
            this.buttonReadExcelFile.Name = "buttonReadExcelFile";
            this.buttonReadExcelFile.Size = new System.Drawing.Size(202, 36);
            this.buttonReadExcelFile.TabIndex = 2;
            this.buttonReadExcelFile.Text = "2 - Read from Excel File";
            this.buttonReadExcelFile.UseVisualStyleBackColor = true;
            this.buttonReadExcelFile.Click += new System.EventHandler(this.buttonReadExcelFile_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(236, 108);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(307, 131);
            this.textBoxContent.TabIndex = 3;
            // 
            // buttonCreateChart
            // 
            this.buttonCreateChart.Location = new System.Drawing.Point(395, 59);
            this.buttonCreateChart.Name = "buttonCreateChart";
            this.buttonCreateChart.Size = new System.Drawing.Size(148, 37);
            this.buttonCreateChart.TabIndex = 4;
            this.buttonCreateChart.Text = "3 - Create Chart";
            this.buttonCreateChart.UseVisualStyleBackColor = true;
            this.buttonCreateChart.Click += new System.EventHandler(this.buttonCreateChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sheet 2";
            // 
            // buttonReadNMCells
            // 
            this.buttonReadNMCells.Location = new System.Drawing.Point(463, 267);
            this.buttonReadNMCells.Name = "buttonReadNMCells";
            this.buttonReadNMCells.Size = new System.Drawing.Size(126, 36);
            this.buttonReadNMCells.TabIndex = 6;
            this.buttonReadNMCells.Text = "Read N:M Cells";
            this.buttonReadNMCells.UseVisualStyleBackColor = true;
            this.buttonReadNMCells.Click += new System.EventHandler(this.buttonReadNMCells_Click);
            // 
            // textBoxStartLine
            // 
            this.textBoxStartLine.Location = new System.Drawing.Point(123, 251);
            this.textBoxStartLine.Name = "textBoxStartLine";
            this.textBoxStartLine.Size = new System.Drawing.Size(52, 26);
            this.textBoxStartLine.TabIndex = 7;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(394, 294);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(52, 26);
            this.textBoxColumns.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Lines:";
            // 
            // textBoxContentCells
            // 
            this.textBoxContentCells.Location = new System.Drawing.Point(16, 356);
            this.textBoxContentCells.Multiline = true;
            this.textBoxContentCells.Name = "textBoxContentCells";
            this.textBoxContentCells.Size = new System.Drawing.Size(574, 282);
            this.textBoxContentCells.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cells Content:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start Line:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Start Column:";
            // 
            // textBoxStartCol
            // 
            this.textBoxStartCol.Location = new System.Drawing.Point(123, 294);
            this.textBoxStartCol.Name = "textBoxStartCol";
            this.textBoxStartCol.Size = new System.Drawing.Size(52, 26);
            this.textBoxStartCol.TabIndex = 14;
            // 
            // textBoxLines
            // 
            this.textBoxLines.Location = new System.Drawing.Point(394, 251);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.Size = new System.Drawing.Size(52, 26);
            this.textBoxLines.TabIndex = 13;
            // 
            // textBoxWorksheetContent
            // 
            this.textBoxWorksheetContent.Location = new System.Drawing.Point(600, 358);
            this.textBoxWorksheetContent.Multiline = true;
            this.textBoxWorksheetContent.Name = "textBoxWorksheetContent";
            this.textBoxWorksheetContent.Size = new System.Drawing.Size(507, 282);
            this.textBoxWorksheetContent.TabIndex = 17;
            // 
            // btnReadWorksheet
            // 
            this.btnReadWorksheet.Location = new System.Drawing.Point(805, 316);
            this.btnReadWorksheet.Name = "btnReadWorksheet";
            this.btnReadWorksheet.Size = new System.Drawing.Size(135, 36);
            this.btnReadWorksheet.TabIndex = 18;
            this.btnReadWorksheet.Text = "Read worksheet";
            this.btnReadWorksheet.UseVisualStyleBackColor = true;
            this.btnReadWorksheet.Click += new System.EventHandler(this.btnReadWorksheet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Worksheet Name:";
            // 
            // textBoxWorksheetName
            // 
            this.textBoxWorksheetName.Location = new System.Drawing.Point(738, 277);
            this.textBoxWorksheetName.Name = "textBoxWorksheetName";
            this.textBoxWorksheetName.Size = new System.Drawing.Size(369, 26);
            this.textBoxWorksheetName.TabIndex = 19;
            // 
            // textBoxWriteContent
            // 
            this.textBoxWriteContent.Location = new System.Drawing.Point(600, 82);
            this.textBoxWriteContent.Multiline = true;
            this.textBoxWriteContent.Name = "textBoxWriteContent";
            this.textBoxWriteContent.Size = new System.Drawing.Size(231, 67);
            this.textBoxWriteContent.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Write the content:";
            // 
            // btnWriteWorksheet
            // 
            this.btnWriteWorksheet.Location = new System.Drawing.Point(600, 163);
            this.btnWriteWorksheet.Name = "btnWriteWorksheet";
            this.btnWriteWorksheet.Size = new System.Drawing.Size(231, 36);
            this.btnWriteWorksheet.TabIndex = 23;
            this.btnWriteWorksheet.Text = "Submit to Worksheet";
            this.btnWriteWorksheet.UseVisualStyleBackColor = true;
            this.btnWriteWorksheet.Click += new System.EventHandler(this.btnWriteWorksheet_Click);
            // 
            // textBoxUsedLines
            // 
            this.textBoxUsedLines.Location = new System.Drawing.Point(738, 220);
            this.textBoxUsedLines.Name = "textBoxUsedLines";
            this.textBoxUsedLines.Size = new System.Drawing.Size(93, 26);
            this.textBoxUsedLines.TabIndex = 25;
            // 
            // btnUsedLines
            // 
            this.btnUsedLines.Location = new System.Drawing.Point(600, 215);
            this.btnUsedLines.Name = "btnUsedLines";
            this.btnUsedLines.Size = new System.Drawing.Size(126, 36);
            this.btnUsedLines.TabIndex = 24;
            this.btnUsedLines.Text = "Used lines";
            this.btnUsedLines.UseVisualStyleBackColor = true;
            this.btnUsedLines.Click += new System.EventHandler(this.btnUsedLines_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(872, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Write the string:";
            // 
            // textBoxStringFind
            // 
            this.textBoxStringFind.Location = new System.Drawing.Point(876, 82);
            this.textBoxStringFind.Multiline = true;
            this.textBoxStringFind.Name = "textBoxStringFind";
            this.textBoxStringFind.Size = new System.Drawing.Size(231, 67);
            this.textBoxStringFind.TabIndex = 26;
            // 
            // btnFindString
            // 
            this.btnFindString.Location = new System.Drawing.Point(876, 163);
            this.btnFindString.Name = "btnFindString";
            this.btnFindString.Size = new System.Drawing.Size(231, 36);
            this.btnFindString.TabIndex = 28;
            this.btnFindString.Text = "Find String in Worksheet";
            this.btnFindString.UseVisualStyleBackColor = true;
            this.btnFindString.Click += new System.EventHandler(this.btnFindString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 650);
            this.Controls.Add(this.btnFindString);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStringFind);
            this.Controls.Add(this.textBoxUsedLines);
            this.Controls.Add(this.btnUsedLines);
            this.Controls.Add(this.btnWriteWorksheet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxWriteContent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxWorksheetName);
            this.Controls.Add(this.btnReadWorksheet);
            this.Controls.Add(this.textBoxWorksheetContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStartCol);
            this.Controls.Add(this.textBoxLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContentCells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxStartLine);
            this.Controls.Add(this.buttonReadNMCells);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateChart);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.buttonReadExcelFile);
            this.Controls.Add(this.buttonWriteExcelFile);
            this.Controls.Add(this.buttonCreateNewFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewFile;
        private System.Windows.Forms.Button buttonWriteExcelFile;
        private System.Windows.Forms.Button buttonReadExcelFile;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonCreateChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReadNMCells;
        private System.Windows.Forms.TextBox textBoxStartLine;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContentCells;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStartCol;
        private System.Windows.Forms.TextBox textBoxLines;
        private System.Windows.Forms.TextBox textBoxWorksheetContent;
        private System.Windows.Forms.Button btnReadWorksheet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWorksheetName;
        private System.Windows.Forms.TextBox textBoxWriteContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnWriteWorksheet;
        private System.Windows.Forms.TextBox textBoxUsedLines;
        private System.Windows.Forms.Button btnUsedLines;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStringFind;
        private System.Windows.Forms.Button btnFindString;
    }
}

