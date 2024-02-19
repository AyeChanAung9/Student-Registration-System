namespace Registration_System.control
{
    partial class Student_View
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
            this.regDBDataSet = new Registration_System.regDBDataSet();
            this.student_informationTableAdapter = new Registration_System.regDBDataSetTableAdapters.student_informationTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.rjButton1 = new StudentAttendanceSystem.RJButton();
            this.btnActive = new StudentAttendanceSystem.RJButton();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewstudent
            // 
            this.dataGridViewstudent.AllowUserToAddRows = false;
            this.dataGridViewstudent.AllowUserToDeleteRows = false;
            this.dataGridViewstudent.AutoGenerateColumns = false;
            this.dataGridViewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewstudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.dataGridViewstudent.Location = new System.Drawing.Point(3, 82);
            this.dataGridViewstudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewstudent.Name = "dataGridViewstudent";
            this.dataGridViewstudent.ReadOnly = true;
            this.dataGridViewstudent.RowHeadersWidth = 51;
            this.dataGridViewstudent.Size = new System.Drawing.Size(975, 350);
            this.dataGridViewstudent.TabIndex = 6;
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studnameDataGridViewTextBoxColumn
            // 
            this.studnameDataGridViewTextBoxColumn.DataPropertyName = "stud_name";
            this.studnameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studnameDataGridViewTextBoxColumn.Name = "studnameDataGridViewTextBoxColumn";
            this.studnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studdobDataGridViewTextBoxColumn
            // 
            this.studdobDataGridViewTextBoxColumn.DataPropertyName = "stud_dob";
            this.studdobDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.studdobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studdobDataGridViewTextBoxColumn.Name = "studdobDataGridViewTextBoxColumn";
            this.studdobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studgenderDataGridViewTextBoxColumn
            // 
            this.studgenderDataGridViewTextBoxColumn.DataPropertyName = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.studgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgenderDataGridViewTextBoxColumn.Name = "studgenderDataGridViewTextBoxColumn";
            this.studgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studsubjectDataGridViewTextBoxColumn
            // 
            this.studsubjectDataGridViewTextBoxColumn.DataPropertyName = "stud_subject";
            this.studsubjectDataGridViewTextBoxColumn.HeaderText = "Subject/Major";
            this.studsubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studsubjectDataGridViewTextBoxColumn.Name = "studsubjectDataGridViewTextBoxColumn";
            this.studsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studyearDataGridViewTextBoxColumn
            // 
            this.studyearDataGridViewTextBoxColumn.DataPropertyName = "stud_year";
            this.studyearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.studyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studyearDataGridViewTextBoxColumn.Name = "studyearDataGridViewTextBoxColumn";
            this.studyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studFnameDataGridViewTextBoxColumn
            // 
            this.studFnameDataGridViewTextBoxColumn.DataPropertyName = "stud_Fname";
            this.studFnameDataGridViewTextBoxColumn.HeaderText = "Father Name";
            this.studFnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studFnameDataGridViewTextBoxColumn.Name = "studFnameDataGridViewTextBoxColumn";
            this.studFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studcontactinfoDataGridViewTextBoxColumn
            // 
            this.studcontactinfoDataGridViewTextBoxColumn.DataPropertyName = "stud_contactinfo";
            this.studcontactinfoDataGridViewTextBoxColumn.HeaderText = "Contactinfo";
            this.studcontactinfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studcontactinfoDataGridViewTextBoxColumn.Name = "studcontactinfoDataGridViewTextBoxColumn";
            this.studcontactinfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "password";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentinformationBindingSource
            // 
            this.studentinformationBindingSource.DataMember = "student_information";
            this.studentinformationBindingSource.DataSource = this.regDBDataSet;
            // 
            // regDBDataSet
            // 
            this.regDBDataSet.DataSetName = "regDBDataSet";
            this.regDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_informationTableAdapter
            // 
            this.student_informationTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(337, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 37);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Year",
            "Subject/Major"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(27, 30);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(283, 38);
            this.comboBoxSearchBy.TabIndex = 8;
            this.comboBoxSearchBy.Text = "Name";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.DarkGray;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.Location = new System.Drawing.Point(767, 21);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(87, 46);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.Text = "Show Inactive";
            this.rjButton1.TextColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Green;
            this.btnActive.BackgroundColor = System.Drawing.Color.Green;
            this.btnActive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActive.BorderRadius = 20;
            this.btnActive.BorderSize = 0;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnActive.Location = new System.Drawing.Point(672, 22);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(87, 46);
            this.btnActive.TabIndex = 10;
            this.btnActive.Text = "Show Active";
            this.btnActive.TextColor = System.Drawing.Color.GhostWhite;
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(885, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Student_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewstudent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Student_View";
            this.Size = new System.Drawing.Size(1020, 454);
            this.Load += new System.EventHandler(this.Student_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewstudent;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private regDBDataSet regDBDataSet;
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private StudentAttendanceSystem.RJButton rjButton1;
        private StudentAttendanceSystem.RJButton btnActive;
        private System.Windows.Forms.Button btnPrint;
    }
}
