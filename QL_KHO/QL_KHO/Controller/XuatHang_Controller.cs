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
    class XuatHang_Controller
    {
        SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        XuatHang HHModel = new XuatHang();


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
            return GetData("XemXH", null);
        }
        public int InsertData(XuatHang XH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("maPX",XH.MaPX),
                new SqlParameter("ngayXuat",XH.NgayXuat),
                new SqlParameter("tongTien",XH.TongTien),
                //new SqlParameter ("maCTX",XH.MaCTX),
                new SqlParameter ("maHH",XH.MaHH),
                new SqlParameter ("soLuong",XH.SoLuong),
                new SqlParameter ("donGia",XH.DonGia),
                
            };
            return ExcuteSQL("ThemXH", para);
        }

        public int UpdateData(XuatHang XH)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("maPX",XH.MaPX),
                new SqlParameter("ngayXuat",XH.NgayXuat),
                new SqlParameter("tongTien",XH.TongTien),
                //new SqlParameter ("maCTX",XH.MaCTX),
                new SqlParameter ("maHH",XH.MaHH),
                new SqlParameter ("soLuong",XH.SoLuong),
                new SqlParameter ("donGia",XH.DonGia),
                
        };
            return ExcuteSQL("SuaXH", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("maPX",ID)
        };
            return ExcuteSQL("XoaXH", para);
        }
        public DataTable TimKiemHH(string strTimKiem)
        {
            return GetData(strTimKiem);
        }
    }
 }

