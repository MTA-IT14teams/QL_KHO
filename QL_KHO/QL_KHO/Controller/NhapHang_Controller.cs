using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_KHO.Model;
using QL_KHO.Controller;

namespace QL_KHO.Controller
{
    class NhapHang_Controller
    { 
        SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        NhapHang HHModel = new NhapHang();

         public DataTable GetData(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
         public DataTable GetData(string NameProc, SqlParameter[] para)
         {

             SqlCommand cmd = new SqlCommand(NameProc, conn);
             // cmd.CommandText = NameProc;
             cmd.CommandType = CommandType.StoredProcedure;
             if (para != null)
                 cmd.Parameters.AddRange(para);
             //cmd.Connection = conn;
             SqlDataAdapter da = new SqlDataAdapter();
             da.SelectCommand = cmd;
             DataTable dt = new DataTable();
             conn.Open();
             da.Fill(dt);
             conn.Close();
             return dt;
         }
         public int ExcuteSQL(string strSQL)
         {
             SqlCommand cmd = new SqlCommand(strSQL, conn);
             conn.Open();
             int count = cmd.ExecuteNonQuery();
             conn.Close();
             return count;
         }
         public int ExcuteSQL(string NameProc, SqlParameter[] para)
         {
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = NameProc;
             cmd.CommandType = CommandType.StoredProcedure;
             if (para != null)
             {
                 cmd.Parameters.AddRange(para);
             }
             cmd.Connection = conn;
             conn.Open();
             int count = cmd.ExecuteNonQuery();
             conn.Close();
             return count;
         }

         public DataTable GetData()
         {
             return GetData("XemNH", null);
         }
         public int InsertData(NhapHang NH)
         {
             SqlParameter[] para =
            {
                new SqlParameter("maPN",NH.MaPN),
                new SqlParameter("ngayNhap",NH.NgayNhap),
                new SqlParameter("tongTien",NH.TongTien),
                //new SqlParameter ("maCTN",NH.MaCTN),
                new SqlParameter ("maHH",NH.MaHH),
                new SqlParameter ("soLuong",NH.SoLuong),
                new SqlParameter ("donGia",NH.DonGia),
                
            };
             return ExcuteSQL("ThemNH", para);
         }
         public int UpdateData(NhapHang NH)
         {
             SqlParameter[] para =
            {
                new SqlParameter("maPN",NH.MaPN),
                new SqlParameter("ngayNhap",NH.NgayNhap),
                new SqlParameter("tongTien",NH.TongTien),
               // new SqlParameter ("maCTN",NH.MaCTN),
                new SqlParameter ("maHH",NH.MaHH),
                new SqlParameter ("soLuong",NH.SoLuong),
                new SqlParameter ("donGia",NH.DonGia),
                
        };
             return ExcuteSQL("SuaNH", para);
         }
         public int DeleteData(string ID)
         {
             SqlParameter[] para =
            {
                new SqlParameter("maPN",ID)
        };
             return ExcuteSQL("XoaNH", para);
         }
         public DataTable TimKiemHH(string strTimKiem)
         {
             return GetData(strTimKiem);
         }
    }
    

}
