using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PAWD_Final_Project
{
    public class Administrator : User
    {   
        public override int Projects_Count { get => base.Projects_Count; set => base.Projects_Count = value; }
        public Administrator()
        {
            SqlConnection con = new SqlConnection("Data Source = (local); Initial Catalog = PAWD; Integrated Security = True");
            string query = "SELECT COUNT(*) FROM projects_table";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            Projects_Count = count;
        }

    }
}
