namespace Registration_System
{
    partial class Student_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Profile));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtAY = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtSI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.StudPFOut_Click1 = new StudentAttendanceSystem.RJButton();
            this.StudPFOut = new StudentAttendanceSystem.RJButton();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoSize = true;
            this.materialCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialCard1.Controls.Add(this.txtStatus);
            this.materialCard1.Controls.Add(this.label7);
            this.materialCard1.Controls.Add(this.txtsub);
            this.materialCard1.Controls.Add(this.txtdob);
            this.materialCard1.Controls.Add(this.txtCI);
            this.materialCard1.Controls.Add(this.txtFN);
            this.materialCard1.Controls.Add(this.txtAY);
            this.materialCard1.Controls.Add(this.txtSN);
            this.materialCard1.Controls.Add(this.txtSI);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(42, 120);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(35, 31, 35, 31);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(35, 31, 35, 31);
            this.materialCard1.Size = new System.Drawing.Size(592, 526);
            this.materialCard1.TabIndex = 0;
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(305, 397);
            this.txtsub.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtsub.Name = "txtsub";
            this.txtsub.ReadOnly = true;
            this.txtsub.Size = new System.Drawing.Size(244, 35);
            this.txtsub.TabIndex = 21;
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(305, 163);
            this.txtdob.Name = "txtdob";
            this.txtdob.ReadOnly = true;
            this.txtdob.Size = new System.Drawing.Size(244, 35);
            this.txtdob.TabIndex = 20;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(305, 287);
            this.txtCI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCI.Name = "txtCI";
            this.txtCI.ReadOnly = true;
            this.txtCI.Size = new System.Drawing.Size(244, 35);
            this.txtCI.TabIndex = 19;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(305, 224);
            this.txtFN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(244, 35);
            this.txtFN.TabIndex = 18;
            // 
            // txtAY
            // 
            this.txtAY.Location = new System.Drawing.Point(305, 343);
            this.txtAY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAY.Name = "txtAY";
            this.txtAY.ReadOnly = true;
            this.txtAY.Size = new System.Drawing.Size(244, 35);
            this.txtAY.TabIndex = 17;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(305, 98);
            this.txtSN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(244, 35);
            this.txtSN.TabIndex = 16;
            // 
            // txtSI
            // 
            this.txtSI.Location = new System.Drawing.Point(305, 33);
            this.txtSI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSI.Name = "txtSI";
            this.txtSI.ReadOnly = true;
            this.txtSI.Size = new System.Drawing.Size(244, 35);
            this.txtSI.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(47, 395);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "Majoring Subject :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(68, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Academic Year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(106, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Info :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(93, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Father Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudPFOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 2);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.StudPFOut_Click1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 100);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(53, -14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 114);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Status :";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(305, 453);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(244, 35);
            this.txtStatus.TabIndex = 23;
            // 
            // StudPFOut_Click1
            // 
            this.StudPFOut_Click1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(81)))));
            this.StudPFOut_Click1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(81)))));
            this.StudPFOut_Click1.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.StudPFOut_Click1.BorderRadius = 20;
            this.StudPFOut_Click1.BorderSize = 0;
            this.StudPFOut_Click1.FlatAppearance.BorderSize = 0;
            this.StudPFOut_Click1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudPFOut_Click1.ForeColor = System.Drawing.Color.White;
            this.StudPFOut_Click1.Image = ((System.Drawing.Image)(resources.GetObject("StudPFOut_Click1.Image")));
            this.StudPFOut_Click1.Location = new System.Drawing.Point(534, 9);
            this.StudPFOut_Click1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StudPFOut_Click1.Name = "StudPFOut_Click1";
            this.StudPFOut_Click1.Size = new System.Drawing.Size(202, 77);
            this.StudPFOut_Click1.TabIndex = 5;
            this.StudPFOut_Click1.Text = "  Log out";
            this.StudPFOut_Click1.TextColor = System.Drawing.Color.White;
            this.StudPFOut_Click1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudPFOut_Click1.UseVisualStyleBackColor = false;
            this.StudPFOut_Click1.Click += new System.EventHandler(this.StudPFOut_Click);
            // 
            // StudPFOut
            // 
            this.StudPFOut.BackColor = System.Drawing.Color.Black;
            this.StudPFOut.BackgroundColor = System.Drawing.Color.Black;
            this.StudPFOut.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.StudPFOut.BorderRadius = 15;
            this.StudPFOut.BorderSize = 0;
            this.StudPFOut.FlatAppearance.BorderSize = 0;
            this.StudPFOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudPFOut.ForeColor = System.Drawing.Color.White;
            this.StudPFOut.Location = new System.Drawing.Point(686, 16);
            this.StudPFOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StudPFOut.Name = "StudPFOut";
            this.StudPFOut.Size = new System.Drawing.Size(182, 67);
            this.StudPFOut.TabIndex = 1;
            this.StudPFOut.Text = "Log Out";
            this.StudPFOut.TextColor = System.Drawing.Color.White;
            this.StudPFOut.UseVisualStyleBackColor = false;
            this.StudPFOut.Click += new System.EventHandler(this.StudPFOut_Click);
            // 
            // Student_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(792, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Student_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Profile";
            this.Load += new System.EventHandler(this.Student_Profile_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtAY;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtSI;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Panel panel1;
        private StudentAttendanceSystem.RJButton StudPFOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private StudentAttendanceSystem.RJButton StudPFOut_Click1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
    }
}