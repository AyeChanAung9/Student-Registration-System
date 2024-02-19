using System.Data.SqlClient;
using System.Data;


namespace Registration_System
{
    class StaffLog
    {
        public static readonly string con_string = "Data Source=LAPTOP-1JTL956L;Initial Catalog=regDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //check user validation
        public static bool IsValid(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from staff_acctable where staff_username ='" + user + "' and staff_pass ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;

        }


    }
}
