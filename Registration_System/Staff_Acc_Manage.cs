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

namespace Registration_System
{
    public partial class Staff_Acc_Manage : Form
    {
        //Database Connection
        public static readonly string constring = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(constring);
        public static SqlCommand cmd;
        public Staff_Acc_Manage()
        {
            InitializeComponent();
        }
        
        private void clear_textbox_upt()
        {
            txtMusername.Clear();
            txtMpass.Clear();
            txtMowner.Clear();
        }
        private void Staff_Acc_Manage_Load(object sender, EventArgs e)
        {
            string ser = "Select * from staff_acctable";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewMAccounts, constring);
        }
        //   
        //  


        public string Musername;
        public string Mpass;
        public string Mowner;
        
            
        private void dataGridViewMAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewMAccounts.Rows[e.RowIndex];

                txtMusername.Text = row.Cells[0].Value.ToString();
                txtMpass.Text = row.Cells[1].Value.ToString();
                txtMowner.Text = row.Cells[2].Value.ToString();


                Musername = row.Cells[0].Value.ToString();
                Mpass = row.Cells[1].Value.ToString();
                Mowner = row.Cells[2].Value.ToString();
            }
        }


        private void btnMAccupdate_Click(object sender, EventArgs e)
        {
            if (txtMusername.Text.Trim() == string.Empty || txtMpass.Text.Trim() == string.Empty || txtMowner.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "UPDATE staff_acctable SET staff_username = '" + txtMusername.Text + "', staff_pass = '" + txtMpass.Text + "', staff_owner = '" + txtMowner.Text + "' WHERE staff_username = '" + Musername + "' AND staff_pass = '" + Mpass + "' AND staff_owner = '" + Mowner + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Staff Account Successfully Updated");
                clear_textbox_upt();
                string ser = "Select * from staff_acctable";
                Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewMAccounts, constring);
            }
        }

        private void btnMAccDelete_Click(object sender, EventArgs e)
        {
            if (txtMusername.Text.Trim() == string.Empty || txtMpass.Text.Trim() == string.Empty || txtMowner.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "DELETE FROM staff_acctable WHERE staff_username = '" + Musername + "' AND staff_pass = '" + Mpass + "' AND staff_owner = '" + Mowner + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Staff Account Successfully Deleted");
                clear_textbox_upt();
                string ser = "Select * from staff_acctable";
                Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewMAccounts, constring);
            }
        }

        
    }
}
