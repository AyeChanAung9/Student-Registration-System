namespace Registration_System
{
    partial class student_view
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
            this.student_View1 = new Registration_System.control.Student_View();
            this.BtnBackstaff = new StudentAttendanceSystem.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_View1
            // 
            this.student_View1.BackColor = System.Drawing.Color.White;
            this.student_View1.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_View1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_View1.Location = new System.Drawing.Point(0, 0);
            this.student_View1.Margin = new System.Windows.Forms.Padding(9);
            this.student_View1.Name = "student_View1";
            this.student_View1.Size = new System.Drawing.Size(1104, 710);
            this.student_View1.TabIndex = 0;
            this.student_View1.Load += new System.EventHandler(this.student_View1_Load);
            // 
            // BtnBackstaff
            // 
            this.BtnBackstaff.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnBackstaff.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.BtnBackstaff.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBackstaff.BorderRadius = 20;
            this.BtnBackstaff.BorderSize = 0;
            this.BtnBackstaff.FlatAppearance.BorderSize = 0;
            this.BtnBackstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackstaff.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackstaff.ForeColor = System.Drawing.Color.White;
            this.BtnBackstaff.Location = new System.Drawing.Point(930, 12);
            this.BtnBackstaff.Name = "BtnBackstaff";
            this.BtnBackstaff.Size = new System.Drawing.Size(163, 94);
            this.BtnBackstaff.TabIndex = 17;
            this.BtnBackstaff.Text = "Log Out";
            this.BtnBackstaff.TextColor = System.Drawing.Color.White;
            this.BtnBackstaff.UseVisualStyleBackColor = false;
            this.BtnBackstaff.Click += new System.EventHandler(this.BtnBackstaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBackstaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 126);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student List:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.student_View1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 520);
            this.panel2.TabIndex = 19;
            // 
            // student_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1104, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "student_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student_view";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private control.Student_View student_View1;
        private StudentAttendanceSystem.RJButton BtnBackstaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}