namespace MosquittoChatClient
{
    partial class FormChat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.textBoxClassRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAvatarLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMsgToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(156, 25);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(232, 31);
            this.textBoxNickName.TabIndex = 1;
            // 
            // textBoxClassRoom
            // 
            this.textBoxClassRoom.Location = new System.Drawing.Point(538, 23);
            this.textBoxClassRoom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxClassRoom.Name = "textBoxClassRoom";
            this.textBoxClassRoom.Size = new System.Drawing.Size(96, 31);
            this.textBoxClassRoom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Classroom:";
            // 
            // textBoxAvatarLoc
            // 
            this.textBoxAvatarLoc.Location = new System.Drawing.Point(828, 23);
            this.textBoxAvatarLoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAvatarLoc.Name = "textBoxAvatarLoc";
            this.textBoxAvatarLoc.Size = new System.Drawing.Size(688, 31);
            this.textBoxAvatarLoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Avatar location:";
            // 
            // textBoxMsgToSend
            // 
            this.textBoxMsgToSend.Location = new System.Drawing.Point(32, 988);
            this.textBoxMsgToSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMsgToSend.Name = "textBoxMsgToSend";
            this.textBoxMsgToSend.Size = new System.Drawing.Size(1308, 31);
            this.textBoxMsgToSend.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1356, 983);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(164, 44);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connection status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(214, 83);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 25);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Disconnected";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(32, 131);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(1488, 840);
            this.dataGridView.TabIndex = 12;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1050);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBoxMsgToSend);
            this.Controls.Add(this.textBoxAvatarLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClassRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNickName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormChat";
            this.Text = "Mosquitto Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.TextBox textBoxClassRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAvatarLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMsgToSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

