﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_KHO.View
{
    public partial class Thống_kê_nhập_xuất : Form
    {
        public Thống_kê_nhập_xuất()
        {
            InitializeComponent();
        }

        private void Load_chart_Click(object sender, EventArgs e)
        {
            this.chart1.Series["HangNhap"].Points.AddXY("Max",33);
            this.chart1.Series["HangNhap"].Points.AddXY("Carl", 20);
            this.chart1.Series["HangNhap"].Points.AddXY("Mark", 50);
            this.chart1.Series["HangNhap"].Points.AddXY("Alli", 40);
        }
    }
}