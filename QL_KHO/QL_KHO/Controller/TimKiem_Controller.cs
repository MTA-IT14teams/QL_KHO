using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QL_KHO.Controller
{
    class TimKiem_Controller
    {
        SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData_proc(string proc)
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
    }
}
