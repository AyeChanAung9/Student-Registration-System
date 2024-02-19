namespace Registration_System
{
    partial class Student_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStuBackMain = new FontAwesome.Sharp.IconButton();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtStudentAccName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegister = new StudentAttendanceSystem.RJButton();
            this.BtnLogin = new StudentAttendanceSystem.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 68);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student Login";
            // 
            // btnStuBackMain
            // 
            this.btnStuBackMain.FlatAppearance.BorderSize = 0;
            this.btnStuBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuBackMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStuBackMain.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnStuBackMain.IconColor = System.Drawing.Color.White;
            this.btnStuBackMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStuBackMain.IconSize = 20;
            this.btnStuBackMain.Location = new System.Drawing.Point(12, 7);
            this.btnStuBackMain.Name = "btnStuBackMain";
            this.btnStuBackMain.Size = new System.Drawing.Size(77, 75);
            this.btnStuBackMain.TabIndex = 23;
            this.btnStuBackMain.UseVisualStyleBackColor = true;
            this.btnStuBackMain.Click += new System.EventHandler(this.btnStuBackMain_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtPassword.Location = new System.Drawing.Point(336, 239);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(308, 48);
            this.TxtPassword.TabIndex = 21;
            // 
            // TxtStudentAccName
            // 
            this.TxtStudentAccName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtStudentAccName.Location = new System.Drawing.Point(336, 155);
            this.TxtStudentAccName.Name = "TxtStudentAccName";
            this.TxtStudentAccName.Size = new System.Drawing.Size(308, 48);
            this.TxtStudentAccName.TabIndex = 20;
            this.TxtStudentAccName.TextChanged += new System.EventHandler(this.TxtStudentAccName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStuBackMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 100);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 42);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(81)))));
            this.BtnRegister.BorderRadius = 20;
            this.BtnRegister.BorderSize = 1;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(445, 352);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(179, 80);
            this.BtnRegister.TabIndex = 24;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.TextColor = System.Drawing.Color.White;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BorderRadius = 20;
            this.BtnLogin.BorderSize = 0;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(200, 352);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(163, 80);
            this.BtnLogin.TabIndex = 22;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.TextColor = System.Drawing.Color.White;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtStudentAccName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Student_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentAttendanceSystem.RJButton BtnRegister;
        private FontAwesome.Sharp.IconButton btnStuBackMain;
        private StudentAttendanceSystem.RJButton BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtStudentAccName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}