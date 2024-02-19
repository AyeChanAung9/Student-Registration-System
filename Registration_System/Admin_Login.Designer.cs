namespace Registration_System
{
    partial class Admin_Login
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
            this.AdminBackMain = new FontAwesome.Sharp.IconButton();
            this.btnAdminLogin = new StudentAttendanceSystem.RJButton();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminBackMain
            // 
            this.AdminBackMain.FlatAppearance.BorderSize = 0;
            this.AdminBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBackMain.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.AdminBackMain.IconColor = System.Drawing.Color.Black;
            this.AdminBackMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdminBackMain.IconSize = 20;
            this.AdminBackMain.Location = new System.Drawing.Point(12, 12);
            this.AdminBackMain.Name = "AdminBackMain";
            this.AdminBackMain.Size = new System.Drawing.Size(77, 75);
            this.AdminBackMain.TabIndex = 16;
            this.AdminBackMain.UseVisualStyleBackColor = true;
            this.AdminBackMain.Click += new System.EventHandler(this.AdminBackMain_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdminLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdminLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdminLogin.BorderRadius = 20;
            this.btnAdminLogin.BorderSize = 0;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(256, 391);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(163, 80);
            this.btnAdminLogin.TabIndex = 14;
            this.btnAdminLogin.Text = "Log in";
            this.btnAdminLogin.TextColor = System.Drawing.Color.White;
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAdminPass.Location = new System.Drawing.Point(303, 277);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.Size = new System.Drawing.Size(308, 48);
            this.txtAdminPass.TabIndex = 13;
            // 
            // txtAdminName
            // 
            this.txtAdminName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAdminName.Location = new System.Drawing.Point(303, 171);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(308, 48);
            this.txtAdminName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 68);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdminBackMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 100);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 42);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.txtAdminName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton AdminBackMain;
        private StudentAttendanceSystem.RJButton btnAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}