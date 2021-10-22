namespace ProjectXML
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
            this.buttonEx5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXmlFile = new System.Windows.Forms.TextBox();
            this.textBoxXsdFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEx6 = new System.Windows.Forms.Button();
            this.listBoxBookTitles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEx7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEx8 = new System.Windows.Forms.Button();
            this.textBoxNewAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSelectedTitle = new System.Windows.Forms.Label();
            this.buttonEx11 = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBooksByCategory = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEx5
            // 
            this.buttonEx5.Location = new System.Drawing.Point(108, 18);
            this.buttonEx5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx5.Name = "buttonEx5";
            this.buttonEx5.Size = new System.Drawing.Size(228, 43);
            this.buttonEx5.TabIndex = 0;
            this.buttonEx5.Text = "Ex. 5 - Generate by code";
            this.buttonEx5.UseVisualStyleBackColor = true;
            this.buttonEx5.Click += new System.EventHandler(this.buttonEx5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xml File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xsd File";
            // 
            // textBoxXmlFile
            // 
            this.textBoxXmlFile.Location = new System.Drawing.Point(108, 70);
            this.textBoxXmlFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXmlFile.Name = "textBoxXmlFile";
            this.textBoxXmlFile.Size = new System.Drawing.Size(709, 26);
            this.textBoxXmlFile.TabIndex = 3;
            // 
            // textBoxXsdFile
            // 
            this.textBoxXsdFile.Location = new System.Drawing.Point(108, 110);
            this.textBoxXsdFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXsdFile.Name = "textBoxXsdFile";
            this.textBoxXsdFile.Size = new System.Drawing.Size(709, 26);
            this.textBoxXsdFile.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(828, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEx6
            // 
            this.buttonEx6.Location = new System.Drawing.Point(678, 150);
            this.buttonEx6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx6.Name = "buttonEx6";
            this.buttonEx6.Size = new System.Drawing.Size(228, 43);
            this.buttonEx6.TabIndex = 7;
            this.buttonEx6.Text = "Ex. 6 - Validate";
            this.buttonEx6.UseVisualStyleBackColor = true;
            this.buttonEx6.Click += new System.EventHandler(this.buttonEx6_Click);
            // 
            // listBoxBookTitles
            // 
            this.listBoxBookTitles.FormattingEnabled = true;
            this.listBoxBookTitles.ItemHeight = 20;
            this.listBoxBookTitles.Location = new System.Drawing.Point(108, 220);
            this.listBoxBookTitles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBookTitles.Name = "listBoxBookTitles";
            this.listBoxBookTitles.Size = new System.Drawing.Size(288, 284);
            this.listBoxBookTitles.TabIndex = 8;
            this.listBoxBookTitles.SelectedIndexChanged += new System.EventHandler(this.listBoxBookTitles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Book titles";
            // 
            // buttonEx7
            // 
            this.buttonEx7.Location = new System.Drawing.Point(108, 515);
            this.buttonEx7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx7.Name = "buttonEx7";
            this.buttonEx7.Size = new System.Drawing.Size(290, 43);
            this.buttonEx7.TabIndex = 10;
            this.buttonEx7.Text = "Ex. 7 - Show Book Titles";
            this.buttonEx7.UseVisualStyleBackColor = true;
            this.buttonEx7.Click += new System.EventHandler(this.buttonEx7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEx8);
            this.groupBox1.Controls.Add(this.textBoxNewAuthorName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(435, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(472, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update author from Book";
            // 
            // buttonEx8
            // 
            this.buttonEx8.Location = new System.Drawing.Point(164, 83);
            this.buttonEx8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx8.Name = "buttonEx8";
            this.buttonEx8.Size = new System.Drawing.Size(266, 43);
            this.buttonEx8.TabIndex = 12;
            this.buttonEx8.Text = "Ex. 8 - Update Book Author";
            this.buttonEx8.UseVisualStyleBackColor = true;
            this.buttonEx8.Click += new System.EventHandler(this.buttonEx8_Click);
            // 
            // textBoxNewAuthorName
            // 
            this.textBoxNewAuthorName.Location = new System.Drawing.Point(164, 43);
            this.textBoxNewAuthorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewAuthorName.Name = "textBoxNewAuthorName";
            this.textBoxNewAuthorName.Size = new System.Drawing.Size(264, 26);
            this.textBoxNewAuthorName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "New author name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected title:";
            // 
            // labelSelectedTitle
            // 
            this.labelSelectedTitle.AutoSize = true;
            this.labelSelectedTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelSelectedTitle.Location = new System.Drawing.Point(573, 218);
            this.labelSelectedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedTitle.Name = "labelSelectedTitle";
            this.labelSelectedTitle.Size = new System.Drawing.Size(158, 20);
            this.labelSelectedTitle.TabIndex = 1;
            this.labelSelectedTitle.Text = "<Selected book title>";
            // 
            // buttonEx11
            // 
            this.buttonEx11.Location = new System.Drawing.Point(108, 603);
            this.buttonEx11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx11.Name = "buttonEx11";
            this.buttonEx11.Size = new System.Drawing.Size(296, 43);
            this.buttonEx11.TabIndex = 15;
            this.buttonEx11.Text = "Ex. 11 -Number of Book by category";
            this.buttonEx11.UseVisualStyleBackColor = true;
            this.buttonEx11.Click += new System.EventHandler(this.buttonEx11_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(254, 568);
            this.textBoxCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(264, 26);
            this.textBoxCategoryName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 572);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category name:";
            // 
            // textBoxBooksByCategory
            // 
            this.textBoxBooksByCategory.Location = new System.Drawing.Point(421, 611);
            this.textBoxBooksByCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBooksByCategory.Name = "textBoxBooksByCategory";
            this.textBoxBooksByCategory.Size = new System.Drawing.Size(97, 26);
            this.textBoxBooksByCategory.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 461);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ex. 9 - Add rate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(608, 421);
            this.textBoxRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(264, 26);
            this.textBoxRate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 426);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rate:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 560);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "Ex. 10 - isbn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(608, 520);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(264, 26);
            this.textBoxISBN.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 525);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "ISBN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 659);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxBooksByCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEx11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.buttonEx7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSelectedTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxBookTitles);
            this.Controls.Add(this.buttonEx6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxXsdFile);
            this.Controls.Add(this.textBoxXmlFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEx5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Worksheet 4 - XML and XPath";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEx5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXmlFile;
        private System.Windows.Forms.TextBox textBoxXsdFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEx6;
        private System.Windows.Forms.ListBox listBoxBookTitles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEx7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEx8;
        private System.Windows.Forms.TextBox textBoxNewAuthorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSelectedTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEx11;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBooksByCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label8;
    }
}

