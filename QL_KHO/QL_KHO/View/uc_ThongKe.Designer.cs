namespace QL_KHO.View
{
    partial class uc_ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.grBTitle = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_HangHoaNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_HangHoaXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.grBData = new System.Windows.Forms.GroupBox();
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.grBTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grBData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÀNG HÓA";
            // 
            // grBTitle
            // 
            this.grBTitle.Controls.Add(this.label1);
            this.grBTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBTitle.Location = new System.Drawing.Point(0, 0);
            this.grBTitle.Name = "grBTitle";
            this.grBTitle.Size = new System.Drawing.Size(654, 87);
            this.grBTitle.TabIndex = 1;
            this.grBTitle.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_HangHoa,
            this.btn_HangHoaNhap,
            this.btn_HangHoaXuat});
            this.menuStrip1.Location = new System.Drawing.Point(4, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_HangHoa
            // 
            this.btn_HangHoa.Name = "btn_HangHoa";
            this.btn_HangHoa.Size = new System.Drawing.Size(71, 20);
            this.btn_HangHoa.Text = "Hàng hóa";
            this.btn_HangHoa.Click += new System.EventHandler(this.btn_HangHoa_Click);
            // 
            // btn_HangHoaNhap
            // 
            this.btn_HangHoaNhap.Name = "btn_HangHoaNhap";
            this.btn_HangHoaNhap.Size = new System.Drawing.Size(101, 20);
            this.btn_HangHoaNhap.Text = "Hàng hóa nhập";
            this.btn_HangHoaNhap.Click += new System.EventHandler(this.btn_HangHoaNhap_Click);
            // 
            // btn_HangHoaXuat
            // 
            this.btn_HangHoaXuat.Name = "btn_HangHoaXuat";
            this.btn_HangHoaXuat.Size = new System.Drawing.Size(96, 20);
            this.btn_HangHoaXuat.Text = "Hàng hóa xuất";
            this.btn_HangHoaXuat.Click += new System.EventHandler(this.btn_HangHoaXuat_Click);
            // 
            // grBData
            // 
            this.grBData.Controls.Add(this.dtg_Data);
            this.grBData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grBData.Location = new System.Drawing.Point(0, 121);
            this.grBData.Name = "grBData";
            this.grBData.Size = new System.Drawing.Size(654, 455);
            this.grBData.TabIndex = 3;
            this.grBData.TabStop = false;
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Data.Location = new System.Drawing.Point(3, 16);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.Size = new System.Drawing.Size(648, 436);
            this.dtg_Data.TabIndex = 0;
            // 
            // uc_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBData);
            this.Controls.Add(this.grBTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "uc_ThongKe";
            this.Size = new System.Drawing.Size(654, 576);
            this.grBTitle.ResumeLayout(false);
            this.grBTitle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem btn_HangHoaNhap;
        private System.Windows.Forms.ToolStripMenuItem btn_HangHoaXuat;
        private System.Windows.Forms.GroupBox grBData;
        private System.Windows.Forms.DataGridView dtg_Data;
    }
}
