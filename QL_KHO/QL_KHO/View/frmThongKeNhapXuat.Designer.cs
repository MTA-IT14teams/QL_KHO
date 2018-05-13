namespace QL_KHO.View
{
    partial class Thống_kê_nhập_xuất
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Load_chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(540, 12);
            this.chart1.Name = "chart1";
            series1.BackImage = "E:\\Nam_3_Kỳ2\\Thuctapnhom\\xanh duong.jpeg";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend1";
            series1.Name = "HangNhap";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(404, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Load_chart
            // 
            this.Load_chart.Location = new System.Drawing.Point(774, 341);
            this.Load_chart.Name = "Load_chart";
            this.Load_chart.Size = new System.Drawing.Size(75, 23);
            this.Load_chart.TabIndex = 1;
            this.Load_chart.Text = "Load_chart";
            this.Load_chart.UseVisualStyleBackColor = true;
            this.Load_chart.Click += new System.EventHandler(this.Load_chart_Click);
            // 
            // Thống_kê_nhập_xuất
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 376);
            this.Controls.Add(this.Load_chart);
            this.Controls.Add(this.chart1);
            this.Name = "Thống_kê_nhập_xuất";
            this.Text = "Thống_kê_nhập_xuất";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Load_chart;
    }
}