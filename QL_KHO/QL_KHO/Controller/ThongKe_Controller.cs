using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QL_KHO.Controller
{
    class ThongKe_Controller
    {
        SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData(string s)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = s;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.Close();
            }
            catch
            {
                cmd.Dispose();
                conn.Close();
            }
            return dt;
        }
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
        public bool ThucHienLenh(string s)
        {
            cmd.CommandText = s;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }
    }
}
