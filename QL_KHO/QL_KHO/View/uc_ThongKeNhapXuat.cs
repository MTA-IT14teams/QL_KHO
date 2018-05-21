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
    public partial class uc_ThongKeNhapXuat : UserControl
    {
        ThongKe_Controller TK = new ThongKe_Controller();
        string nam = null;

        string t1_nhap;
        string t2_nhap;
        string t3_nhap;
        string t4_nhap;
        string t5_nhap;
        string t6_nhap;
        string t7_nhap;
        string t8_nhap;
        string t9_nhap;
        string t10_nhap;
        string t11_nhap;
        string t12_nhap;

        string t1_xuat;
        string t2_xuat;
        string t3_xuat;
        string t4_xuat;
        string t5_xuat;
        string t6_xuat;
        string t7_xuat;
        string t8_xuat;
        string t9_xuat;
        string t10_xuat;
        string t11_xuat;
        string t12_xuat;
        public uc_ThongKeNhapXuat()
        {
            InitializeComponent();
        }

        private void tinhtiennhap()
        {
            ThongKe_Controller tk = new ThongKe_Controller();

            nam = txtNam.Text.Trim();
            t1_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-01-01", nam + "-01-31");
            t2_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-02-01", nam + "-02-28");
            t3_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-03-01", nam + "-03-31");
            t4_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-04-01", nam + "-04-30");
            t5_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-05-01", nam + "-05-31");
            t6_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-06-01", nam + "-06-30");
            t7_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-07-01", nam + "-07-31");
            t8_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-08-01", nam + "-08-31");
            t9_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-09-01", nam + "-09-30");
            t10_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-10-01", nam + "-10-31");
            t11_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-11-01", nam + "-11-30");
            t12_nhap = tk.GetData_proc_tinhtien("tienthuthang", nam + "-12-01", nam + "-12-31");
        }
        private void tinhtienxuat()
        {
            ThongKe_Controller tk = new ThongKe_Controller();
            nam = txtNam.Text.Trim();
            t1_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-01-01", nam + "-01-31");
            t2_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-02-01", nam + "-02-28");
            t3_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-03-01", nam + "-03-31");
            t4_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-04-01", nam + "-04-30");
            t5_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-05-01", nam + "-05-31");
            t6_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-06-01", nam + "-06-30");
            t7_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-07-01", nam + "-07-31");
            t8_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-08-01", nam + "-08-31");
            t9_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-09-01", nam + "-09-30");
            t10_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-10-01", nam + "-10-31");
            t11_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-11-01", nam + "-11-30");
            t12_xuat = tk.GetData_proc_tinhtien("tienxuatthang", nam + "-12-01", nam + "-12-31");
        }

        private void LoadChart_Click(object sender, EventArgs e)
        {
            if (txtNam.ToString() == null)
                MessageBox.Show("Bạn chưa nhập năm để thống kê");
            else
            {
                tinhtiennhap();
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 1", t1_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 2", t2_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 3", t3_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 4", t4_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 5", t5_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 6", t6_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 7", t7_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 8", t8_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 9", t9_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 10", t10_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 11", t11_nhap);
                this.chart_Nhap.Series["Tổng tiền"].Points.AddXY("Thang 12", t12_nhap);
            }
        }

        private void LoadChart_xuathang_Click(object sender, EventArgs e)
        {
            if (txtNam.ToString() == null)
                MessageBox.Show("Bạn chưa nhập năm để thống kê");
            else
            {
                tinhtienxuat();
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 1", t1_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 2", t2_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 3", t3_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 4", t4_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 5", t5_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 6", t6_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 7", t7_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 8", t8_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 9", t9_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 10", t10_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 11", t11_xuat);
                this.chart_XuatHang.Series["Tổng tiền"].Points.AddXY("Thang 12", t12_xuat);
            }
        }



    }
}
