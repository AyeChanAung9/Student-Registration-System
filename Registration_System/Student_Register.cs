using FontAwesome.Sharp;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class Student_Register : Form
    {
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
        public Student_Register()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login sl = new Student_Login();
            sl.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            /*
            string qry = @"insert into stud_acctable values('" + txtRegAccName.Text + "','" + txtRegAccPassword.Text +"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            */
            string message = "Registration Successful";
            string title = "Success";
            MessageBox.Show(message, title);

            this.Hide();
            StudentCard sc = new StudentCard();
            sc.sName = TxtStudentName.Text;
            sc.Sub = CboSubject.Text;
            sc.Year = comboBoxRegYear.Text;
            sc.Gender = cbogender.Text;
            sc.DOB = dtpDOB.Text;
            sc.Fname = TxtFatherName.Text;
            sc.Cont = TxtContactNumber.Text;
            sc.accname = txtRegAccName.Text;
            sc.accpass = txtRegAccPassword.Text;
            sc.Show();
        }

    }
}
