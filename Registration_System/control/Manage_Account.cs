using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System
{
    public partial class Manage_Account : UserControl
    {
        public Manage_Account()
        {
            InitializeComponent();
        }

        
        private void Manage_Account_Load(object sender, EventArgs e)
        {
        }

        

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff_Acc_Manage SM= new Staff_Acc_Manage();
            SM.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_Acc_Manage Admin = new Admin_Acc_Manage();
            Admin.Show();   
        }
    }
}
