using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_KHO.View
{
    public partial class uc_ThongKeNhapXuat : UserControl
    {
        public uc_ThongKeNhapXuat()
        {
            InitializeComponent();
        }

        private void Load_chart_Click(object sender, EventArgs e)
        {
            using(ChartEntities db = new ChartEntities())
            {
                this.chart1.DataSource = db.PhieuNhaps.ToList();
                this.chart1.Series["HangNhap"].XValueMember = "ngayXuat";
                this.chart1.Series["HangNhap"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                this.chart1.Series["HangNhap"].YValueMembers = "tongTien";
                this.chart1.Series["HangNhap"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
        }

        private void uc_ThongKeNhapXuat_Load(object sender, EventArgs e)
        {
            using (ChartEntities db = new ChartEntities())
            {
                this.chart1.DataSource = db.PhieuNhaps.ToList();
                this.chart1.Series["HangNhap"].XValueMember = "ngayXuat";
                this.chart1.Series["HangNhap"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                this.chart1.Series["HangNhap"].YValueMembers = "tongTien";
                this.chart1.Series["HangNhap"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
            
        }
    }
}
