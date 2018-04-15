using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KHO.Model
{
    class PhieuXuat
    {
        private string maPX;
        private DateTime ngayXuat;
        private float tongTien;
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
    }
}
