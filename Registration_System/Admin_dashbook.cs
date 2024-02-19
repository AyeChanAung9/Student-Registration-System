using FontAwesome.Sharp;
using Registration_System.control;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Registration_System
{
    public partial class Admin_dashbook : Form
    {
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

        //Database Connection
        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        public string Acc { get; set; }

        public Admin_dashbook()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Admin_Login al = new Admin_Login();
                al.Show();
            }
        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            manage_Account1.Visible = false;
            uptDelStud1.Visible = false;
            student_View1.Visible = false;
            dashpanel.Visible = true;
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            manage_Account1.Visible = true;
            uptDelStud1.Visible = false;
            student_View1.Visible = false;
            dashpanel.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uptDelStud1.Visible = true;
            manage_Account1.Visible = false;
            student_View1.Visible = false;
            dashpanel.Visible = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            manage_Account1.Visible = false;
            uptDelStud1.Visible = false;
            student_View1.Visible = true;
            dashpanel.Visible = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_dashbook_Load(object sender, EventArgs e)
        {
            /*
            Rectangle resolutionRectangle= System.Windows.Forms.Screen.FromControl(this).Bounds;
            if(this.Width >= resolutionRectangle.Width || this.Height >= resolutionRectangle.Height) 
            {
                this.WindowState = FormWindowState.Maximized;
            }

            lblcount.Text = Attendance.Attendance.Count("select count(*) from student_information WHERE activity = 'Active';", con_string).ToString();
            lblnamepass.Text = Acc;
            */
        }
    }
}
