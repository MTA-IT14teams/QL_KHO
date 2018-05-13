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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Load_chart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_chart
            // 
            this.Load_chart.Location = new System.Drawing.Point(701, 406);
            this.Load_chart.Name = "Load_chart";
            this.Load_chart.Size = new System.Drawing.Size(75, 23);
            this.Load_chart.TabIndex = 3;
            this.Load_chart.Text = "Load_chart";
            this.Load_chart.UseVisualStyleBackColor = true;
            this.Load_chart.Click += new System.EventHandler(this.Load_chart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(414, 84);
            this.chart1.Name = "chart1";
            series1.BackImage = "E:\\Nam_3_Kỳ2\\Thuctapnhom\\xanh duong.jpeg";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.Legend = "Legend1";
            series1.Name = "HangNhap";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(526, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // uc_ThongKeNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Load_chart);
            this.Controls.Add(this.chart1);
            this.Name = "uc_ThongKeNhapXuat";
            this.Size = new System.Drawing.Size(988, 526);
            this.Load += new System.EventHandler(this.uc_ThongKeNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
