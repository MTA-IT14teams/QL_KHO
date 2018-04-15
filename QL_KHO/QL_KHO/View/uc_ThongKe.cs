using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_KHO.Controller;
namespace QL_KHO.View
{
    public partial class uc_ThongKe : UserControl
    {
        ThongKe_Controller TK = new ThongKe_Controller();
        DataTable dt = new DataTable();
        public uc_ThongKe()
        {
            InitializeComponent();
        }

        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            dt = TK.GetData_proc("tk_hh");
            dtg_Data.DataSource = dt;
        }

        private void btn_HangHoaNhap_Click(object sender, EventArgs e)
        {
            dt = TK.GetData_proc("tk_nhap");
            dtg_Data.DataSource = dt;
        }

        private void btn_HangHoaXuat_Click(object sender, EventArgs e)
        {
            dt = TK.GetData_proc("tk_xuat");
            dtg_Data.DataSource = dt;
        }

    }
}
