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
    public partial class Admin_Acc_Manage : Form
    {
        //Database Connection
        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;
        public Admin_Acc_Manage()
        {
            InitializeComponent();
        }

        private void clear_textbox_upt()
        {
            txtAdminUsername.Clear();
            txtAdminPass.Clear();
            txtAdminOwner.Clear();
        }
        private void Admin_Acc_Manage_Load(object sender, EventArgs e)
        {
            string ser = "Select * from acc_admintable";
            Attendance.Attendance.DisplayAndSearchAllData(ser, dataGridViewAdminAccounts, con_string);
        }
        public string AdminUsername;
        public string AdminPass;
        public string AdminOwner;
        /**/

        private void dataGridViewAdminAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dataGridViewAdminAccounts.Rows[e.RowIndex];

                txtAdminUsername.Text = r.Cells[0].Value.ToString();
                txtAdminPass.Text = r.Cells[1].Value.ToString();
                txtAdminOwner.Text = r.Cells[2].Value.ToString();


                AdminUsername = r.Cells[0].Value.ToString();
                AdminPass = r.Cells[1].Value.ToString();
                AdminOwner = r.Cells[2].Value.ToString();

            }
        }
        private void aAccUpdate_Click(object sender, EventArgs e)
        {

            if (txtAdminUsername.Text.Trim() == string.Empty || txtAdminPass.Text.Trim() == string.Empty || txtAdminOwner.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill out all the fields !", "Required All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "UPDATE acc_admintable SET username = '" + txtAdminUsername.Text + "', password = '" + txtAdminPass.Text + "', owner = '" + txtAdminOwner.Text + "' WHERE username = '" + AdminUsername + "' AND password = '" + AdminPass + "' AND owner = '" + AdminOwner + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Admin Account Successfully Updated");
                clear_textbox_upt();
                string s = "Select * from acc_admintable";
                Attendance.Attendance.DisplayAndSearchAllData(s, dataGridViewAdminAccounts, con_string);
            }
        }

        
    }
    }

