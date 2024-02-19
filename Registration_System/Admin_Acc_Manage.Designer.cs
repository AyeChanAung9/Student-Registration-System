namespace Registration_System
{
    partial class Admin_Acc_Manage
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
            this.dataGridViewAdminAccounts = new System.Windows.Forms.DataGridView();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aAccUpdate = new StudentAttendanceSystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdminAccounts
            // 
            this.dataGridViewAdminAccounts.AllowUserToAddRows = false;
            this.dataGridViewAdminAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAdminAccounts.AllowUserToResizeColumns = false;
            this.dataGridViewAdminAccounts.AllowUserToResizeRows = false;
            this.dataGridViewAdminAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewAdminAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdminAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAdminAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewAdminAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminAccounts.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewAdminAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdminAccounts.Name = "dataGridViewAdminAccounts";
            this.dataGridViewAdminAccounts.ReadOnly = true;
            this.dataGridViewAdminAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewAdminAccounts.RowHeadersWidth = 51;
            this.dataGridViewAdminAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdminAccounts.ShowCellErrors = false;
            this.dataGridViewAdminAccounts.ShowEditingIcon = false;
            this.dataGridViewAdminAccounts.ShowRowErrors = false;
            this.dataGridViewAdminAccounts.Size = new System.Drawing.Size(533, 235);
            this.dataGridViewAdminAccounts.TabIndex = 107;
            this.dataGridViewAdminAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminAccounts_CellClick);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(271, 290);
            this.txtAdminPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(161, 20);
            this.txtAdminPass.TabIndex = 115;
            // 
            // txtAdminOwner
            // 
            this.txtAdminOwner.Location = new System.Drawing.Point(271, 338);
            this.txtAdminOwner.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminOwner.Name = "txtAdminOwner";
            this.txtAdminOwner.Size = new System.Drawing.Size(161, 20);
            this.txtAdminOwner.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(121, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 109;
            this.label5.Text = "UserName :";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(271, 245);
            this.txtAdminUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(161, 20);
            this.txtAdminUsername.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(175, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 110;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(131, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "Password :";
            // 
            // aAccUpdate
            // 
            this.aAccUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.aAccUpdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.aAccUpdate.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.aAccUpdate.BorderRadius = 20;
            this.aAccUpdate.BorderSize = 3;
            this.aAccUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aAccUpdate.FlatAppearance.BorderSize = 0;
            this.aAccUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aAccUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAccUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.aAccUpdate.Location = new System.Drawing.Point(326, 395);
            this.aAccUpdate.Name = "aAccUpdate";
            this.aAccUpdate.Size = new System.Drawing.Size(105, 48);
            this.aAccUpdate.TabIndex = 113;
            this.aAccUpdate.Text = "Update";
            this.aAccUpdate.TextColor = System.Drawing.Color.Transparent;
            this.aAccUpdate.UseVisualStyleBackColor = false;
            this.aAccUpdate.Click += new System.EventHandler(this.aAccUpdate_Click);
            // 
            // Admin_Acc_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 487);
            this.Controls.Add(this.dataGridViewAdminAccounts);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.txtAdminOwner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdminUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aAccUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_Acc_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Account Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Admin_Acc_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdminAccounts;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtAdminOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private StudentAttendanceSystem.RJButton aAccUpdate;
    }
}