namespace Registration_System
{
    partial class Student_Register
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
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.TxtContactNumber = new System.Windows.Forms.TextBox();
            this.CboSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegAccPassword = new System.Windows.Forms.TextBox();
            this.btnBackLogin = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegAccName = new System.Windows.Forms.TextBox();
            this.comboBoxRegYear = new System.Windows.Forms.ComboBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRegister = new StudentAttendanceSystem.RJButton();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.ForeColor = System.Drawing.Color.Black;
            this.TxtStudentName.Location = new System.Drawing.Point(675, 169);
            this.TxtStudentName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(339, 48);
            this.TxtStudentName.TabIndex = 1;
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.ForeColor = System.Drawing.Color.Black;
            this.TxtFatherName.Location = new System.Drawing.Point(220, 400);
            this.TxtFatherName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.Size = new System.Drawing.Size(339, 48);
            this.TxtFatherName.TabIndex = 5;
            // 
            // TxtContactNumber
            // 
            this.TxtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtContactNumber.Location = new System.Drawing.Point(584, 367);
            this.TxtContactNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtContactNumber.Multiline = true;
            this.TxtContactNumber.Name = "TxtContactNumber";
            this.TxtContactNumber.Size = new System.Drawing.Size(452, 101);
            this.TxtContactNumber.TabIndex = 6;
            // 
            // CboSubject
            // 
            this.CboSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CboSubject.FormattingEnabled = true;
            this.CboSubject.Items.AddRange(new object[] {
            "CS",
            "IR",
            "ECO",
            "ENG"});
            this.CboSubject.Location = new System.Drawing.Point(217, 245);
            this.CboSubject.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CboSubject.Name = "CboSubject";
            this.CboSubject.Size = new System.Drawing.Size(339, 48);
            this.CboSubject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Registration Form";
            // 
            // txtRegAccPassword
            // 
            this.txtRegAccPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtRegAccPassword.Location = new System.Drawing.Point(245, 110);
            this.txtRegAccPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRegAccPassword.Name = "txtRegAccPassword";
            this.txtRegAccPassword.PasswordChar = '*';
            this.txtRegAccPassword.Size = new System.Drawing.Size(339, 48);
            this.txtRegAccPassword.TabIndex = 8;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.FlatAppearance.BorderSize = 0;
            this.btnBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackLogin.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnBackLogin.IconColor = System.Drawing.Color.White;
            this.btnBackLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackLogin.IconSize = 20;
            this.btnBackLogin.Location = new System.Drawing.Point(53, 19);
            this.btnBackLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(78, 65);
            this.btnBackLogin.TabIndex = 11;
            this.btnBackLogin.UseVisualStyleBackColor = true;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRegAccName);
            this.groupBox2.Controls.Add(this.txtRegAccPassword);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(276, 482);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(611, 182);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For Student Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(47, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(47, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 37);
            this.label9.TabIndex = 9;
            this.label9.Text = "User Name";
            // 
            // txtRegAccName
            // 
            this.txtRegAccName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtRegAccName.Location = new System.Drawing.Point(245, 46);
            this.txtRegAccName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRegAccName.Name = "txtRegAccName";
            this.txtRegAccName.Size = new System.Drawing.Size(339, 48);
            this.txtRegAccName.TabIndex = 7;
            // 
            // comboBoxRegYear
            // 
            this.comboBoxRegYear.FormattingEnabled = true;
            this.comboBoxRegYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "1H",
            "2H",
            "3H",
            "M",
            "Q"});
            this.comboBoxRegYear.Location = new System.Drawing.Point(218, 171);
            this.comboBoxRegYear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxRegYear.Name = "comboBoxRegYear";
            this.comboBoxRegYear.Size = new System.Drawing.Size(339, 48);
            this.comboBoxRegYear.TabIndex = 13;
            // 
            // cbogender
            // 
            this.cbogender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbogender.Location = new System.Drawing.Point(218, 320);
            this.cbogender.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(339, 48);
            this.cbogender.TabIndex = 14;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(675, 248);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(339, 44);
            this.dtpDOB.TabIndex = 15;
            this.dtpDOB.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBackLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 100);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contact Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Father Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 37);
            this.label8.TabIndex = 23;
            this.label8.Text = "Subject";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRegister.BorderRadius = 20;
            this.BtnRegister.BorderSize = 0;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(492, 678);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(230, 89);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.TextColor = System.Drawing.Color.White;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Student_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 828);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.comboBoxRegYear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.CboSubject);
            this.Controls.Add(this.TxtContactNumber);
            this.Controls.Add(this.TxtFatherName);
            this.Controls.Add(this.TxtStudentName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Student_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Register";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtContactNumber;
        private System.Windows.Forms.ComboBox CboSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegAccPassword;
        private StudentAttendanceSystem.RJButton BtnRegister;
        private FontAwesome.Sharp.IconButton btnBackLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegAccName;
        private System.Windows.Forms.ComboBox comboBoxRegYear;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFatherName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}