using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class StudentCard : Form
    {
        public string sName { get; set; }
        public string Gender { get; set; }
        public string Sub { get; set; }
        public string Year { get; set; }
        public string DOB { get; set; }
        public string Fname { get; set; }
        public string Cont { get; set; }
        public string accname { get; set; }
        public string accpass { get; set; }


        public static readonly string con_string = "LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        public static SqlCommand cmd;

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


        public StudentCard()
        {
            InitializeComponent();
            //for rounded corner
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //for rounded corner
        }

        private void StudentCard_Load(object sender, EventArgs e)
        {
            lblstuName.Text = sName;
            lblstuDOB.Text = DOB;
            lblstuGen.Text = Gender;
            lblstuSub.Text = Sub;
            lblstuYear.Text = Year;
            lblstuFname.Text = Fname;
            lblstuCon.Text = Cont;


            string qry = "Select * from student_information where stud_subject = '" + lblstuSub.Text + "' and stud_year = '" + lblstuYear.Text + "'";
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            int rn = dt.Rows.Count;
            lblstuID.Text = lblstuYear.Text + lblstuSub.Text+"-"+(rn+1).ToString();
        }

        private void btnRegToHome_Click(object sender, EventArgs e)
        {
            string qry = @"insert into student_information values('" + lblstuID.Text + "','" + lblstuName.Text + "','" + lblstuDOB.Text + "','" + lblstuGen.Text + "','" + lblstuSub.Text + "','" + lblstuYear.Text + "','" + lblstuFname.Text + "','" + lblstuCon.Text + "','" + "Active" + "','"+ accname + "','" + accpass + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();

            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            // Capture the entire form and its contents to the bitmap
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            // Print the captured image
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawImage(bmp, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
}
