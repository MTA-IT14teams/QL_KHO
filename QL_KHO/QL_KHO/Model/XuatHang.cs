using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHO.Model
{
    class XuatHang
    {
        private string maPX;
        private DateTime ngayXuat;
        private int tongTien;
       // private string maCTX;
        private string maHH;
        private int soLuong;
        private int donGia;

        public string MaPX
        {
            get { return maPX; }
            set { maPX = value; }
        }
        public DateTime NgayXuat
        {

            get { return ngayXuat; }
            set { ngayXuat = value; }
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
