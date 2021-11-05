
namespace Mosquitto_B
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrokerDomain = new System.Windows.Forms.TextBox();
            this.btnConnectBroker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Broker Domain";
            // 
            // textBoxBrokerDomain
            // 
            this.textBoxBrokerDomain.Location = new System.Drawing.Point(12, 92);
            this.textBoxBrokerDomain.Name = "textBoxBrokerDomain";
            this.textBoxBrokerDomain.Size = new System.Drawing.Size(188, 26);
            this.textBoxBrokerDomain.TabIndex = 27;
            // 
            // btnConnectBroker
            // 
            this.btnConnectBroker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnectBroker.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConnectBroker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectBroker.Location = new System.Drawing.Point(12, 124);
            this.btnConnectBroker.Name = "btnConnectBroker";
            this.btnConnectBroker.Size = new System.Drawing.Size(231, 39);
            this.btnConnectBroker.TabIndex = 26;
            this.btnConnectBroker.Text = "Connect to broker";
            this.btnConnectBroker.UseVisualStyleBackColor = false;
            this.btnConnectBroker.Click += new System.EventHandler(this.btnConnectBroker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "*** Publisher ***";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Topic";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Message To send";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(17, 276);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(341, 107);
            this.textBox.TabIndex = 32;
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPublish.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPublish.Location = new System.Drawing.Point(268, 186);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(90, 39);
            this.buttonPublish.TabIndex = 31;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrokerDomain);
            this.Controls.Add(this.btnConnectBroker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrokerDomain;
        private System.Windows.Forms.Button btnConnectBroker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonPublish;
    }
}

