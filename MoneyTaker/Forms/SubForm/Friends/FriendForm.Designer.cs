﻿namespace MoneyTaker
{
    partial class FriendForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FriendData = new System.Windows.Forms.DataGridView();
            this.FriendName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FriendData)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendData
            // 
            this.FriendData.AllowUserToResizeColumns = false;
            this.FriendData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.FriendData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FriendData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FriendData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FriendData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FriendData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FriendData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FriendName,
            this.FriendNick,
            this.FriendEmail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FriendData.DefaultCellStyle = dataGridViewCellStyle3;
            this.FriendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendData.EnableHeadersVisualStyles = false;
            this.FriendData.Location = new System.Drawing.Point(0, 0);
            this.FriendData.Name = "FriendData";
            this.FriendData.RowTemplate.Height = 23;
            this.FriendData.Size = new System.Drawing.Size(703, 237);
            this.FriendData.TabIndex = 0;
            // 
            // FriendName
            // 
            this.FriendName.HeaderText = "이름";
            this.FriendName.Name = "FriendName";
            this.FriendName.Width = 180;
            // 
            // FriendNick
            // 
            this.FriendNick.HeaderText = "닉네임";
            this.FriendNick.Name = "FriendNick";
            this.FriendNick.Width = 180;
            // 
            // FriendEmail
            // 
            this.FriendEmail.HeaderText = "이메일";
            this.FriendEmail.Name = "FriendEmail";
            this.FriendEmail.Width = 302;
            // 
            // FriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(703, 237);
            this.Controls.Add(this.FriendData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FriendForm";
            this.Text = "FriendForm";
            ((System.ComponentModel.ISupportInitialize)(this.FriendData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FriendData;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendEmail;
    }
}