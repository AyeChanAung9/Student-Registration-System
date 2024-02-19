namespace Registration_System.control
{
    partial class UptDelStud
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uptStudMajor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uptStudCon = new System.Windows.Forms.TextBox();
            this.uptStudName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regDBDataSet = new Registration_System.regDBDataSet();
            this.regDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regDBDataSet1 = new Registration_System.regDBDataSet1();
            this.regDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewstudent = new System.Windows.Forms.DataGridView();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studcontactinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_informationTableAdapter = new Registration_System.regDBDataSetTableAdapters.student_informationTableAdapter();
            this.uptStudYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uptStudUser = new System.Windows.Forms.TextBox();
            this.uptStudDOB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uptStudFname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uptStudPass = new System.Windows.Forms.TextBox();
            this.uptStudGen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSearchByForManage = new System.Windows.Forms.ComboBox();
            this.txtSearchToManage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInactive = new StudentAttendanceSystem.RJButton();
            this.btnActive = new StudentAttendanceSystem.RJButton();
            this.bthStudentDelete = new StudentAttendanceSystem.RJButton();
            this.btnStudentupdate = new StudentAttendanceSystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uptStudMajor
            // 
            this.uptStudMajor.Location = new System.Drawing.Point(153, 321);
            this.uptStudMajor.Name = "uptStudMajor";
            this.uptStudMajor.Size = new System.Drawing.Size(199, 35);
            this.uptStudMajor.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(75, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Major :";
            // 
            // uptStudCon
            // 
            this.uptStudCon.Location = new System.Drawing.Point(153, 364);
            this.uptStudCon.Multiline = true;
            this.uptStudCon.Name = "uptStudCon";
            this.uptStudCon.Size = new System.Drawing.Size(199, 95);
            this.uptStudCon.TabIndex = 81;
            // 
            // uptStudName
            // 
            this.uptStudName.Location = new System.Drawing.Point(153, 280);
            this.uptStudName.Name = "uptStudName";
            this.uptStudName.Size = new System.Drawing.Size(199, 35);
            this.uptStudName.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(21, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 79;
            this.label7.Text = "Contact Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(3, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "StudentName :";
            // 
            // regDBDataSet
            // 
            this.regDBDataSet.DataSetName = "regDBDataSet";
            this.regDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regDBDataSetBindingSource
            // 
            this.regDBDataSetBindingSource.DataSource = this.regDBDataSet;
            this.regDBDataSetBindingSource.Position = 0;
            // 
            // regDBDataSet1
            // 
            this.regDBDataSet1.DataSetName = "regDBDataSet1";
            this.regDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regDBDataSet1BindingSource
            // 
            this.regDBDataSet1BindingSource.DataSource = this.regDBDataSet1;
            this.regDBDataSet1BindingSource.Position = 0;
            // 
            // dataGridViewstudent
            // 
            this.dataGridViewstudent.AllowUserToAddRows = false;
            this.dataGridViewstudent.AllowUserToDeleteRows = false;
            this.dataGridViewstudent.AutoGenerateColumns = false;
            this.dataGridViewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewstudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studidDataGridViewTextBoxColumn,
            this.studnameDataGridViewTextBoxColumn,
            this.studdobDataGridViewTextBoxColumn,
            this.studgenderDataGridViewTextBoxColumn,
            this.studsubjectDataGridViewTextBoxColumn,
            this.studyearDataGridViewTextBoxColumn,
            this.studFnameDataGridViewTextBoxColumn,
            this.studcontactinfoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dataGridViewstudent.DataSource = this.studentinformationBindingSource;
            this.dataGridViewstudent.Location = new System.Drawing.Point(4, 59);
            this.dataGridViewstudent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewstudent.Name = "dataGridViewstudent";
            this.dataGridViewstudent.ReadOnly = true;
            this.dataGridViewstudent.RowHeadersWidth = 51;
            this.dataGridViewstudent.Size = new System.Drawing.Size(1087, 208);
            this.dataGridViewstudent.TabIndex = 86;
            this.dataGridViewstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudent_CellClick);
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "stud_id";
            this.studidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            this.studidDataGridViewTextBoxColumn.Width = 116;
            // 
            // studnameDataGridViewTextBoxColumn
            // 
            this.studnameDataGridViewTextBoxColumn.DataPropertyName = "stud_name";
            this.studnameDataGridViewTextBoxColumn.HeaderText = "stud_name";
            this.studnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studnameDataGridViewTextBoxColumn.Name = "studnameDataGridViewTextBoxColumn";
            this.studnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studnameDataGridViewTextBoxColumn.Width = 156;
            // 
            // studdobDataGridViewTextBoxColumn
            // 
            this.studdobDataGridViewTextBoxColumn.DataPropertyName = "stud_dob";
            this.studdobDataGridViewTextBoxColumn.HeaderText = "stud_dob";
            this.studdobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studdobDataGridViewTextBoxColumn.Name = "studdobDataGridViewTextBoxColumn";
            this.studdobDataGridViewTextBoxColumn.ReadOnly = true;
            this.studdobDataGridViewTextBoxColumn.Width = 138;
            // 
            // studgenderDataGridViewTextBoxColumn
            // 
            this.studgenderDataGridViewTextBoxColumn.DataPropertyName = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.HeaderText = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgenderDataGridViewTextBoxColumn.Name = "studgenderDataGridViewTextBoxColumn";
            this.studgenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.studgenderDataGridViewTextBoxColumn.Width = 173;
            // 
            // studsubjectDataGridViewTextBoxColumn
            // 
            this.studsubjectDataGridViewTextBoxColumn.DataPropertyName = "stud_subject";
            this.studsubjectDataGridViewTextBoxColumn.HeaderText = "stud_subject";
            this.studsubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studsubjectDataGridViewTextBoxColumn.Name = "studsubjectDataGridViewTextBoxColumn";
            this.studsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.studsubjectDataGridViewTextBoxColumn.Width = 173;
            // 
            // studyearDataGridViewTextBoxColumn
            // 
            this.studyearDataGridViewTextBoxColumn.DataPropertyName = "stud_year";
            this.studyearDataGridViewTextBoxColumn.HeaderText = "stud_year";
            this.studyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studyearDataGridViewTextBoxColumn.Name = "studyearDataGridViewTextBoxColumn";
            this.studyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.studyearDataGridViewTextBoxColumn.Width = 142;
            // 
            // studFnameDataGridViewTextBoxColumn
            // 
            this.studFnameDataGridViewTextBoxColumn.DataPropertyName = "stud_Fname";
            this.studFnameDataGridViewTextBoxColumn.HeaderText = "stud_Fname";
            this.studFnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studFnameDataGridViewTextBoxColumn.Name = "studFnameDataGridViewTextBoxColumn";
            this.studFnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studFnameDataGridViewTextBoxColumn.Width = 171;
            // 
            // studcontactinfoDataGridViewTextBoxColumn
            // 
            this.studcontactinfoDataGridViewTextBoxColumn.DataPropertyName = "stud_contactinfo";
            this.studcontactinfoDataGridViewTextBoxColumn.HeaderText = "stud_contactinfo";
            this.studcontactinfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studcontactinfoDataGridViewTextBoxColumn.Name = "studcontactinfoDataGridViewTextBoxColumn";
            this.studcontactinfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.studcontactinfoDataGridViewTextBoxColumn.Width = 211;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 145;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDataGridViewTextBoxColumn.Width = 89;
            // 
            // studentinformationBindingSource
            // 
            this.studentinformationBindingSource.DataMember = "student_information";
            this.studentinformationBindingSource.DataSource = this.regDBDataSetBindingSource;
            // 
            // student_informationTableAdapter
            // 
            this.student_informationTableAdapter.ClearBeforeFill = true;
            // 
            // uptStudYear
            // 
            this.uptStudYear.Location = new System.Drawing.Point(510, 323);
            this.uptStudYear.Name = "uptStudYear";
            this.uptStudYear.Size = new System.Drawing.Size(214, 35);
            this.uptStudYear.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(413, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 91;
            this.label3.Text = "Year :";
            // 
            // uptStudUser
            // 
            this.uptStudUser.Location = new System.Drawing.Point(510, 368);
            this.uptStudUser.Name = "uptStudUser";
            this.uptStudUser.Size = new System.Drawing.Size(214, 35);
            this.uptStudUser.TabIndex = 90;
            // 
            // uptStudDOB
            // 
            this.uptStudDOB.Location = new System.Drawing.Point(510, 281);
            this.uptStudDOB.Name = "uptStudDOB";
            this.uptStudDOB.Size = new System.Drawing.Size(214, 35);
            this.uptStudDOB.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(358, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "UserName :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(413, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "DOB :";
            // 
            // uptStudFname
            // 
            this.uptStudFname.Location = new System.Drawing.Point(870, 324);
            this.uptStudFname.Name = "uptStudFname";
            this.uptStudFname.Size = new System.Drawing.Size(218, 35);
            this.uptStudFname.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(723, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 97;
            this.label8.Text = "Father Name:";
            // 
            // uptStudPass
            // 
            this.uptStudPass.Location = new System.Drawing.Point(870, 365);
            this.uptStudPass.Name = "uptStudPass";
            this.uptStudPass.Size = new System.Drawing.Size(218, 35);
            this.uptStudPass.TabIndex = 96;
            // 
            // uptStudGen
            // 
            this.uptStudGen.Location = new System.Drawing.Point(870, 283);
            this.uptStudGen.Name = "uptStudGen";
            this.uptStudGen.Size = new System.Drawing.Size(218, 35);
            this.uptStudGen.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label9.Location = new System.Drawing.Point(748, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 94;
            this.label9.Text = "Password :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(768, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 93;
            this.label10.Text = "Gender :";
            // 
            // comboBoxSearchByForManage
            // 
            this.comboBoxSearchByForManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchByForManage.FormattingEnabled = true;
            this.comboBoxSearchByForManage.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Year",
            "Subject/Major"});
            this.comboBoxSearchByForManage.Location = new System.Drawing.Point(151, 11);
            this.comboBoxSearchByForManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchByForManage.Name = "comboBoxSearchByForManage";
            this.comboBoxSearchByForManage.Size = new System.Drawing.Size(283, 37);
            this.comboBoxSearchByForManage.TabIndex = 100;
            this.comboBoxSearchByForManage.Text = "Name";
            // 
            // txtSearchToManage
            // 
            this.txtSearchToManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchToManage.Location = new System.Drawing.Point(443, 12);
            this.txtSearchToManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchToManage.Name = "txtSearchToManage";
            this.txtSearchToManage.Size = new System.Drawing.Size(268, 35);
            this.txtSearchToManage.TabIndex = 99;
            this.txtSearchToManage.TextChanged += new System.EventHandler(this.txtSearchToManage_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 29);
            this.label11.TabIndex = 102;
            this.label11.Text = "SEARCH BY";
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInactive.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInactive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInactive.BorderRadius = 20;
            this.btnInactive.BorderSize = 0;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(883, 10);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(192, 40);
            this.btnInactive.TabIndex = 104;
            this.btnInactive.Text = "Show Inactive";
            this.btnInactive.TextColor = System.Drawing.Color.White;
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActive.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActive.BorderRadius = 20;
            this.btnActive.BorderSize = 0;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(723, 12);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(150, 40);
            this.btnActive.TabIndex = 103;
            this.btnActive.Text = "Show Active";
            this.btnActive.TextColor = System.Drawing.Color.White;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // bthStudentDelete
            // 
            this.bthStudentDelete.BackColor = System.Drawing.Color.Firebrick;
            this.bthStudentDelete.BackgroundColor = System.Drawing.Color.Firebrick;
            this.bthStudentDelete.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.bthStudentDelete.BorderRadius = 20;
            this.bthStudentDelete.BorderSize = 3;
            this.bthStudentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthStudentDelete.FlatAppearance.BorderSize = 0;
            this.bthStudentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthStudentDelete.ForeColor = System.Drawing.Color.White;
            this.bthStudentDelete.Location = new System.Drawing.Point(896, 408);
            this.bthStudentDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bthStudentDelete.Name = "bthStudentDelete";
            this.bthStudentDelete.Size = new System.Drawing.Size(192, 74);
            this.bthStudentDelete.TabIndex = 83;
            this.bthStudentDelete.Text = "Delete";
            this.bthStudentDelete.TextColor = System.Drawing.Color.White;
            this.bthStudentDelete.UseVisualStyleBackColor = false;
            this.bthStudentDelete.Click += new System.EventHandler(this.bthStudentDelete_Click);
            // 
            // btnStudentupdate
            // 
            this.btnStudentupdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStudentupdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStudentupdate.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStudentupdate.BorderRadius = 20;
            this.btnStudentupdate.BorderSize = 3;
            this.btnStudentupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentupdate.FlatAppearance.BorderSize = 0;
            this.btnStudentupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentupdate.ForeColor = System.Drawing.Color.White;
            this.btnStudentupdate.Location = new System.Drawing.Point(540, 411);
            this.btnStudentupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnStudentupdate.Name = "btnStudentupdate";
            this.btnStudentupdate.Size = new System.Drawing.Size(181, 74);
            this.btnStudentupdate.TabIndex = 82;
            this.btnStudentupdate.Text = "Update";
            this.btnStudentupdate.TextColor = System.Drawing.Color.White;
            this.btnStudentupdate.UseVisualStyleBackColor = false;
            this.btnStudentupdate.Click += new System.EventHandler(this.btnStudentupdate_Click);
            // 
            // UptDelStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxSearchByForManage);
            this.Controls.Add(this.txtSearchToManage);
            this.Controls.Add(this.uptStudFname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uptStudPass);
            this.Controls.Add(this.uptStudGen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uptStudYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uptStudUser);
            this.Controls.Add(this.uptStudDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewstudent);
            this.Controls.Add(this.uptStudMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthStudentDelete);
            this.Controls.Add(this.btnStudentupdate);
            this.Controls.Add(this.uptStudCon);
            this.Controls.Add(this.uptStudName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UptDelStud";
            this.Size = new System.Drawing.Size(1100, 543);
            this.Load += new System.EventHandler(this.UptDelStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uptStudMajor;
        private System.Windows.Forms.Label label1;
        private StudentAttendanceSystem.RJButton bthStudentDelete;
        private StudentAttendanceSystem.RJButton btnStudentupdate;
        private System.Windows.Forms.TextBox uptStudCon;
        private System.Windows.Forms.TextBox uptStudName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private regDBDataSet regDBDataSet;
        private System.Windows.Forms.BindingSource regDBDataSetBindingSource;
        private regDBDataSet1 regDBDataSet1;
        private System.Windows.Forms.BindingSource regDBDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridViewstudent;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private regDBDataSetTableAdapters.student_informationTableAdapter student_informationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studcontactinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox uptStudYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uptStudUser;
        private System.Windows.Forms.TextBox uptStudDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uptStudFname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uptStudPass;
        private System.Windows.Forms.TextBox uptStudGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSearchByForManage;
        private System.Windows.Forms.TextBox txtSearchToManage;
        private System.Windows.Forms.Label label11;
        private StudentAttendanceSystem.RJButton btnActive;
        private StudentAttendanceSystem.RJButton btnInactive;
    }
}
