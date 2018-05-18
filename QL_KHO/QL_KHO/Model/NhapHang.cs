using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHO.Model
{
  public class NhapHang
    {
        private string maPN;
        private DateTime ngayNhap;
        private int tongTien;
        //private string maCTN;
        private string maHH;
        private int soLuong;
        private int donGia;

        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }
        public DateTime NgayNhap
        {

            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; ; }
        }
        
        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; ; }
        }
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; ; }
        }
    }
}
