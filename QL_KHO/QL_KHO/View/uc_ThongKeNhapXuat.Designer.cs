namespace QL_KHO.View
{
    partial class uc_ThongKeNhapXuat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_XuatHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadChart_xuathang = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadChart = new System.Windows.Forms.Button();
            this.chart_Nhap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_XuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Nhap)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_XuatHang
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_XuatHang.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_XuatHang.Legends.Add(legend5);
            this.chart_XuatHang.Location = new System.Drawing.Point(202, 363);
            this.chart_XuatHang.Name = "chart_XuatHang";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Tổng tiền";
            this.chart_XuatHang.Series.Add(series5);
            this.chart_XuatHang.Size = new System.Drawing.Size(821, 223);
            this.chart_XuatHang.TabIndex = 12;
            this.chart_XuatHang.Text = "chart1";
            // 
            // LoadChart_xuathang
            // 
            this.LoadChart_xuathang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoadChart_xuathang.Location = new System.Drawing.Point(38, 178);
            this.LoadChart_xuathang.Name = "LoadChart_xuathang";
            this.LoadChart_xuathang.Size = new System.Drawing.Size(128, 23);
            this.LoadChart_xuathang.TabIndex = 11;
            this.LoadChart_xuathang.Text = "Thống kê xuất hàng ";
            this.LoadChart_xuathang.UseVisualStyleBackColor = true;
            this.LoadChart_xuathang.Click += new System.EventHandler(this.LoadChart_xuathang_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(79, 95);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(87, 20);
            this.txtNam.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Năm";
            // 
            // LoadChart
            // 
            this.LoadChart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoadChart.Location = new System.Drawing.Point(38, 149);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(128, 23);
            this.LoadChart.TabIndex = 8;
            this.LoadChart.Text = "Thống kê nhập hàng ";
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.LoadChart_Click);
            // 
            // chart_Nhap
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_Nhap.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_Nhap.Legends.Add(legend6);
            this.chart_Nhap.Location = new System.Drawing.Point(202, 77);
            this.chart_Nhap.Name = "chart_Nhap";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Tổng tiền";
            this.chart_Nhap.Series.Add(series6);
            this.chart_Nhap.Size = new System.Drawing.Size(821, 270);
            this.chart_Nhap.TabIndex = 7;
            this.chart_Nhap.Text = "chart1";
            // 
            // ThongKeNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_XuatHang);
            this.Controls.Add(this.LoadChart_xuathang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadChart);
            this.Controls.Add(this.chart_Nhap);
            this.Name = "ThongKeNhap";
            this.Size = new System.Drawing.Size(1142, 651);
            ((System.ComponentModel.ISupportInitialize)(this.chart_XuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Nhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_XuatHang;
        private System.Windows.Forms.Button LoadChart_xuathang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Nhap;
    }
}
