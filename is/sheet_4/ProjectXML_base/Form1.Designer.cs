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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEx10 = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEx10);
            this.groupBox2.Controls.Add(this.textBoxISBN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(436, 412);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(470, 146);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Rate or/and ISBN";
            // 
            // buttonEx10
            // 
            this.buttonEx10.Location = new System.Drawing.Point(272, 72);
            this.buttonEx10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx10.Name = "buttonEx10";
            this.buttonEx10.Size = new System.Drawing.Size(156, 43);
            this.buttonEx10.TabIndex = 18;
            this.buttonEx10.Text = "Ex. 10 - Add ISBN";
            this.buttonEx10.UseVisualStyleBackColor = true;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(72, 85);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(169, 26);
            this.textBoxISBN.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "ISBN:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 28);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 26);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ex. 9 - Add rate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEx7);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEx10;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label7;
    }
}

