
namespace ProjectXML
{
    partial class Form2
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnExecuteXPath = new System.Windows.Forms.Button();
            this.textBoxXmlFile = new System.Windows.Forms.TextBox();
            this.textBoxXPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(700, 47);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(78, 30);
            this.btnOpenFile.TabIndex = 12;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExecuteXPath
            // 
            this.btnExecuteXPath.Location = new System.Drawing.Point(700, 91);
            this.btnExecuteXPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExecuteXPath.Name = "btnExecuteXPath";
            this.btnExecuteXPath.Size = new System.Drawing.Size(78, 30);
            this.btnExecuteXPath.TabIndex = 11;
            this.btnExecuteXPath.Text = "Execute";
            this.btnExecuteXPath.UseVisualStyleBackColor = true;
            this.btnExecuteXPath.Click += new System.EventHandler(this.btnExecuteXPath_Click);
            // 
            // textBoxXmlFile
            // 
            this.textBoxXmlFile.Location = new System.Drawing.Point(156, 52);
            this.textBoxXmlFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXmlFile.Name = "textBoxXmlFile";
            this.textBoxXmlFile.Size = new System.Drawing.Size(536, 26);
            this.textBoxXmlFile.TabIndex = 10;
            // 
            // textBoxXPath
            // 
            this.textBoxXPath.Location = new System.Drawing.Point(156, 95);
            this.textBoxXPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXPath.Name = "textBoxXPath";
            this.textBoxXPath.Size = new System.Drawing.Size(536, 26);
            this.textBoxXPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "XPath Expression";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xml File";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(17, 151);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(761, 287);
            this.textBoxResult.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnExecuteXPath);
            this.Controls.Add(this.textBoxXmlFile);
            this.Controls.Add(this.textBoxXPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExecuteXPath;
        private System.Windows.Forms.TextBox textBoxXmlFile;
        private System.Windows.Forms.TextBox textBoxXPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}