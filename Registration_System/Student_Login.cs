using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class Student_Login : Form
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

        public Student_Login()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Register sr = new Student_Register();
            sr.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (DBClass.IsValid(TxtStudentAccName.Text, TxtPassword.Text) == false)
            {
                MessageBox.Show("Invalid UserName Or Password","Warning",MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Student_Profile sp = new Student_Profile();
                sp.username = TxtStudentAccName.Text;
                sp.pass = TxtPassword.Text;
                sp.Show();
            }
            
        }

        private void btnStuBackMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void TxtStudentAccName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
