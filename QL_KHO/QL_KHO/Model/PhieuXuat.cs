﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QL_KHO.Model
{
    class PhieuXuat
    {
        private string maPX;
        private DateTime ngayXuat;
        private float tongTien;
        SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public string MaPX
        {
            get
            {
                return maPX;
            }

            set
            {
                maPX = value;
            }
        }
        public DateTime NgayXuat
        {
            get
            {
                return ngayXuat;
            }

            set
            {
                ngayXuat = value;
            }
        }
        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
        public DataTable GetData(string s)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = s;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch
            {
                cmd.Dispose();
                conn.Close();
            }
            return dt;
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
