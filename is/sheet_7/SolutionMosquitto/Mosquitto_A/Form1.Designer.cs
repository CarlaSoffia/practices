
namespace Mosquitto_A
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
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBrokerDomain = new System.Windows.Forms.TextBox();
            this.btnConnectSubscribe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.Location = new System.Drawing.Point(12, 199);
            this.textBoxReceived.Multiline = true;
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(419, 239);
            this.textBoxReceived.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(258, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Unsubscribe all topics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBrokerDomain
            // 
            this.textBoxBrokerDomain.Location = new System.Drawing.Point(12, 92);
            this.textBoxBrokerDomain.Name = "textBoxBrokerDomain";
            this.textBoxBrokerDomain.Size = new System.Drawing.Size(188, 26);
            this.textBoxBrokerDomain.TabIndex = 21;
            // 
            // btnConnectSubscribe
            // 
            this.btnConnectSubscribe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnectSubscribe.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConnectSubscribe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectSubscribe.Location = new System.Drawing.Point(12, 124);
            this.btnConnectSubscribe.Name = "btnConnectSubscribe";
            this.btnConnectSubscribe.Size = new System.Drawing.Size(231, 39);
            this.btnConnectSubscribe.TabIndex = 20;
            this.btnConnectSubscribe.Text = "Connect and Subscribe";
            this.btnConnectSubscribe.UseVisualStyleBackColor = false;
            this.btnConnectSubscribe.Click += new System.EventHandler(this.btnConnectSubscribe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "*** Subscriber ***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Broker Domain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBrokerDomain);
            this.Controls.Add(this.btnConnectSubscribe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBrokerDomain;
        private System.Windows.Forms.Button btnConnectSubscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

