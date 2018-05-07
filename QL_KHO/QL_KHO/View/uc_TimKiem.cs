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
    public partial class uc_TimKiem : UserControl
    {
        DataTable dt;
        TimKiem_Controller TK = new TimKiem_Controller();
        public uc_TimKiem()
        {
            InitializeComponent();
        }
        private void ShowData()
        {
            dt = TK.GetData_proc("xuat_hh_tk");
            dtg_Data.DataSource = dt;
        }
        private void uc_TimKiem_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txt_TenHH_TextChanged(object sender, EventArgs e)
        {
            string tenhh = string.Format("[tenHH] like '%{0}%'", txt_TenHH.Text);
            dt.DefaultView.RowFilter = tenhh;
        }

        private void txt_TenHH_Click(object sender, EventArgs e)
        {
            txt_TenHH.Text = "";
        }

        private void txt_TenNCC_Click(object sender, EventArgs e)
        {
            txt_TenNCC.Text = "";
        }

        private void txt_TenNCC_TextChanged(object sender, EventArgs e)
        {
            string tenncc = string.Format("[tenNCC] like '%{0}%'",txt_TenNCC.Text);
            dt.DefaultView.RowFilter = tenncc;
        }       

    }
}
