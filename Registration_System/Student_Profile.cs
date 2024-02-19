using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class Student_Profile : Form
    {
        public string username { get; set; }
        public string pass { get; set; }

        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//for rounded corner
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Student_Profile()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void StudPFOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do You Want To Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Student_Login sl = new Student_Login();
                sl.Show();
            }
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {
            string qry = @"Select * from student_information where username ='" + username + "' and pass ='" + pass + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txtSI.Text = sqlDataReader["stud_id"].ToString();
                txtSN.Text = sqlDataReader["stud_name"].ToString();
                txtdob.Text = sqlDataReader["stud_dob"].ToString();
                txtFN.Text = sqlDataReader["stud_Fname"].ToString();
                txtCI.Text = sqlDataReader["stud_contactinfo"].ToString();
                txtAY.Text = sqlDataReader["stud_year"].ToString();
                txtsub.Text = sqlDataReader["stud_subject"].ToString();
                txtStatus.Text = sqlDataReader["activity"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
