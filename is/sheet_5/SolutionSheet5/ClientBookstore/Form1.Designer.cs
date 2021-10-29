
namespace ClientBookstore
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
            this.btnGetBooks = new System.Windows.Forms.Button();
            this.btnFilterCat = new System.Windows.Forms.Button();
            this.btnFilterTitle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.textBoxYearNew = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxTitleNew = new System.Windows.Forms.TextBox();
            this.textBoxAuthorNew = new System.Windows.Forms.TextBox();
            this.textBoxPriceNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.comboBoxCategoriesNew = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetBooks
            // 
            this.btnGetBooks.Location = new System.Drawing.Point(21, 28);
            this.btnGetBooks.Name = "btnGetBooks";
            this.btnGetBooks.Size = new System.Drawing.Size(112, 31);
            this.btnGetBooks.TabIndex = 0;
            this.btnGetBooks.Text = "Get Books";
            this.btnGetBooks.UseVisualStyleBackColor = true;
            this.btnGetBooks.Click += new System.EventHandler(this.btnGetBooks_Click);
            // 
            // btnFilterCat
            // 
            this.btnFilterCat.Location = new System.Drawing.Point(186, 71);
            this.btnFilterCat.Name = "btnFilterCat";
            this.btnFilterCat.Size = new System.Drawing.Size(84, 31);
            this.btnFilterCat.TabIndex = 1;
            this.btnFilterCat.Text = "Filter";
            this.btnFilterCat.UseVisualStyleBackColor = true;
            this.btnFilterCat.Click += new System.EventHandler(this.btnFilterCat_Click);
            // 
            // btnFilterTitle
            // 
            this.btnFilterTitle.Location = new System.Drawing.Point(10, 213);
            this.btnFilterTitle.Name = "btnFilterTitle";
            this.btnFilterTitle.Size = new System.Drawing.Size(84, 31);
            this.btnFilterTitle.TabIndex = 2;
            this.btnFilterTitle.Text = "Filter";
            this.btnFilterTitle.UseVisualStyleBackColor = true;
            this.btnFilterTitle.Click += new System.EventHandler(this.btnFilterTitle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(669, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(669, 119);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(94, 31);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // textBoxYearNew
            // 
            this.textBoxYearNew.Location = new System.Drawing.Point(284, 121);
            this.textBoxYearNew.Name = "textBoxYearNew";
            this.textBoxYearNew.Size = new System.Drawing.Size(100, 26);
            this.textBoxYearNew.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(14, 175);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(256, 26);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxTitleNew
            // 
            this.textBoxTitleNew.Location = new System.Drawing.Point(80, 45);
            this.textBoxTitleNew.Name = "textBoxTitleNew";
            this.textBoxTitleNew.Size = new System.Drawing.Size(583, 26);
            this.textBoxTitleNew.TabIndex = 9;
            // 
            // textBoxAuthorNew
            // 
            this.textBoxAuthorNew.Location = new System.Drawing.Point(80, 82);
            this.textBoxAuthorNew.Name = "textBoxAuthorNew";
            this.textBoxAuthorNew.Size = new System.Drawing.Size(583, 26);
            this.textBoxAuthorNew.TabIndex = 10;
            // 
            // textBoxPriceNew
            // 
            this.textBoxPriceNew.Location = new System.Drawing.Point(80, 118);
            this.textBoxPriceNew.Name = "textBoxPriceNew";
            this.textBoxPriceNew.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceNew.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Title";
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Location = new System.Drawing.Point(21, 73);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(442, 204);
            this.listBoxBooks.TabIndex = 19;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // comboBoxCategoriesNew
            // 
            this.comboBoxCategoriesNew.FormattingEnabled = true;
            this.comboBoxCategoriesNew.Location = new System.Drawing.Point(520, 121);
            this.comboBoxCategoriesNew.Name = "comboBoxCategoriesNew";
            this.comboBoxCategoriesNew.Size = new System.Drawing.Size(143, 28);
            this.comboBoxCategoriesNew.TabIndex = 20;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(10, 73);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(170, 28);
            this.comboBoxCategory.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilterTitle);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.btnFilterCat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(505, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 301);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetBooks);
            this.groupBox2.Controls.Add(this.listBoxBooks);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 301);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fetch All Books";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddBook);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.textBoxTitleNew);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxCategoriesNew);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.textBoxAuthorNew);
            this.groupBox3.Controls.Add(this.textBoxYearNew);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxPriceNew);
            this.groupBox3.Location = new System.Drawing.Point(12, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 165);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bookstore client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetBooks;
        private System.Windows.Forms.Button btnFilterCat;
        private System.Windows.Forms.Button btnFilterTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox textBoxYearNew;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxTitleNew;
        private System.Windows.Forms.TextBox textBoxAuthorNew;
        private System.Windows.Forms.TextBox textBoxPriceNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ComboBox comboBoxCategoriesNew;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

