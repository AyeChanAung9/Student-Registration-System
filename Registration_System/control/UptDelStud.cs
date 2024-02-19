using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Registration_System.control
{
    public partial class UptDelStud : UserControl
    {
        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;

        public UptDelStud()
        {
            InitializeComponent();
        }   
        private void clear_textbox_upt()
        {
            uptStudName.Clear();
            uptStudDOB.Clear();
            uptStudGen.Clear();
            uptStudMajor.Clear();
            uptStudYear.Clear();
            uptStudFname.Clear();
            uptStudCon.Clear();
            uptStudUser.Clear();
            uptStudPass.Clear();
        }
        private void UptDelStud_Load(object sender, EventArgs e)
        {
            string ser = "SELECT * FROM student_information WHERE activity = 'Active'";

            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
        }

        private void txtSearchToManage_TextChanged(object sender, EventArgs e)
        {
            string s = "Select * from student_information where activity = 'Active' and stud_name LIKE'%" + txtSearchToManage.Text + "%'; ";
            Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewstudent, con_string);

            if (comboBoxSearchByForManage.SelectedIndex == 0)
            {
                string chg0 = "Select * from student_information where activity = 'Active' and stud_id LIKE'%" + txtSearchToManage.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg0, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchByForManage.SelectedIndex == 1)
            {
                string chg2 = "Select * from student_information where activity = 'Active' and stud_name LIKE'%" + txtSearchToManage.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchByForManage.SelectedIndex == 2)
            {
                string chg1 = "Select * from student_information where activity = 'Active' and stud_year LIKE'%" + txtSearchToManage.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg1, dataGridViewstudent, con_string);
            }

            if (comboBoxSearchByForManage.SelectedIndex == 3)
            {
                string chg2 = "Select * from student_information where activity = 'Active' and stud_subject LIKE'%" + txtSearchToManage.Text + "%'; ";
                Attendance.Attendance.DisplayAndSearchAllData(chg2, dataGridViewstudent, con_string);
            }

        }
        public string studname;
        public string studDOB;
        public string studGen;
        public string studMajor;
        public string studYear;
        public string studFname;
        public string studCon;
        public string studUser;
        public string studPass;
        private void dataGridViewstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewstudent.Rows[e.RowIndex];
                uptStudName.Text = row.Cells[1].Value.ToString();
                uptStudDOB.Text = row.Cells[2].Value.ToString(); 
                uptStudGen.Text = row.Cells[3].Value.ToString();
                uptStudMajor.Text = row.Cells[4].Value.ToString();
                uptStudYear.Text = row.Cells[5].Value.ToString();
                uptStudFname.Text = row.Cells[6].Value.ToString();
                uptStudCon.Text = row.Cells[7].Value.ToString();
                uptStudUser.Text = row.Cells[8].Value.ToString();
                uptStudPass.Text = row.Cells[9].Value.ToString();


                studname = row.Cells[1].Value.ToString();
                studDOB = row.Cells[2].Value.ToString();
                studGen= row.Cells[3].Value.ToString();
                studMajor = row.Cells[4].Value.ToString();
                studYear = row.Cells[5].Value.ToString();
                studFname = row.Cells[6].Value.ToString();
                studCon = row.Cells[7].Value.ToString();
                studUser= row.Cells[8].Value.ToString();
                studPass = row.Cells[9].Value.ToString();
            }
        }

        private void btnStudentupdate_Click(object sender, EventArgs e)
        {
            if (uptStudName.Text.Trim() == string.Empty ||
                uptStudName.Text.Trim() == string.Empty ||
                uptStudDOB.Text.Trim() == string.Empty ||
                uptStudGen.Text.Trim() == string.Empty ||
                uptStudMajor.Text.Trim() == string.Empty ||
                uptStudYear.Text.Trim() == string.Empty ||
                uptStudFname.Text.Trim() == string.Empty ||
                uptStudCon.Text.Trim() == string.Empty ||
                uptStudUser.Text.Trim() == string.Empty ||
                uptStudPass.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "UPDATE student_information SET stud_name = '" + uptStudName.Text + "', " +
                    "stud_dob = '" + uptStudDOB.Text + "', " +
                    "stud_gender = '" + uptStudGen.Text + "', " +
                    "stud_subject = '" + uptStudMajor.Text + "', " +
                    "stud_year = '" + uptStudYear.Text + "', " +
                    "stud_Fname = '" + uptStudFname.Text + "', " +
                    "stud_contactinfo = '" + uptStudCon.Text + "', " +
                    "username = '" + uptStudUser.Text + "', " +
                    "pass = '" + uptStudPass.Text +
                    "' WHERE stud_name = '" + studname +
                    "' AND stud_dob = '" + studDOB +
                    "' AND stud_gender = '" + studGen +
                    "' AND stud_subject = '" + studMajor +
                    "' AND stud_year = '" + studYear +
                    "' AND stud_Fname = '" + studFname +
                    "' AND stud_contactinfo = '" + studCon +
                    "' AND username = '" + studUser +
                    "' AND pass = '" + studPass + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Info Successfully Updated");
                clear_textbox_upt();
                string ser = "SELECT * FROM student_information WHERE activity = 'Active'";
                Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
            }
        }

        private void bthStudentDelete_Click(object sender, EventArgs e)
        {
            if (uptStudName.Text.Trim() == string.Empty ||
               uptStudName.Text.Trim() == string.Empty ||
               uptStudDOB.Text.Trim() == string.Empty ||
               uptStudGen.Text.Trim() == string.Empty ||
               uptStudMajor.Text.Trim() == string.Empty ||
               uptStudYear.Text.Trim() == string.Empty ||
               uptStudFname.Text.Trim() == string.Empty ||
               uptStudCon.Text.Trim() == string.Empty ||
               uptStudUser.Text.Trim() == string.Empty ||
               uptStudPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "UPDATE student_information SET activity = 'Inactive' WHERE stud_name = '" + studname + "'";

                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Successfully Deleted");
                clear_textbox_upt();
                string ser = "SELECT * FROM student_information WHERE activity = 'Active'";
                Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            string ser = "SELECT * FROM student_information WHERE activity = 'Active'";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            string ser = "SELECT * FROM student_information WHERE activity = 'Inactive'";

            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewstudent, con_string);
        }
    }
}
