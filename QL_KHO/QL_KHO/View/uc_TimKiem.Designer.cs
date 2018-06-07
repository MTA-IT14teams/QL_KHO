namespace QL_KHO.View
{
    partial class uc_TimKiem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tênHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_TenHH = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_TenNCC = new System.Windows.Forms.ToolStripTextBox();
            this.grB_Data = new System.Windows.Forms.GroupBox();
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grB_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tênHàngHóaToolStripMenuItem,
            this.txt_TenHH});
            this.menuStrip1.Location = new System.Drawing.Point(4, 107);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(238, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tênHàngHóaToolStripMenuItem
            // 
            this.tênHàngHóaToolStripMenuItem.Name = "tênHàngHóaToolStripMenuItem";
            this.tênHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.tênHàngHóaToolStripMenuItem.Text = "Tên hàng hóa";
            // 
            // txt_TenHH
            // 
            this.txt_TenHH.Name = "txt_TenHH";
            this.txt_TenHH.Size = new System.Drawing.Size(136, 23);
            this.txt_TenHH.Click += new System.EventHandler(this.txt_TenHH_Click);
            this.txt_TenHH.TextChanged += new System.EventHandler(this.txt_TenHH_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.txt_TenNCC});
            this.menuStrip2.Location = new System.Drawing.Point(4, 147);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(237, 27);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 23);
            this.toolStripMenuItem1.Text = "Tên nhà cung cấp";
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(113, 23);
            this.txt_TenNCC.Click += new System.EventHandler(this.txt_TenNCC_Click);
            this.txt_TenNCC.TextChanged += new System.EventHandler(this.txt_TenNCC_TextChanged);
            // 
            // grB_Data
            // 
            this.grB_Data.Controls.Add(this.dtg_Data);
            this.grB_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grB_Data.Location = new System.Drawing.Point(0, 205);
            this.grB_Data.Name = "grB_Data";
            this.grB_Data.Size = new System.Drawing.Size(1164, 362);
            this.grB_Data.TabIndex = 3;
            this.grB_Data.TabStop = false;
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHH,
            this.tenHH,
            this.tenNCC,
            this.soluong,
            this.ghichu});
            this.dtg_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Data.Location = new System.Drawing.Point(3, 16);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.Size = new System.Drawing.Size(1158, 343);
            this.dtg_Data.TabIndex = 0;
            // 
            // maHH
            // 
            this.maHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maHH.DataPropertyName = "maHH";
            this.maHH.HeaderText = "Mã hàng hóa";
            this.maHH.Name = "maHH";
            this.maHH.Width = 150;
            // 
            // tenHH
            // 
            this.tenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHH.DataPropertyName = "tenHH";
            this.tenHH.HeaderText = "Tên hàng hóa";
            this.tenHH.Name = "tenHH";
            // 
            // tenNCC
            // 
            this.tenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // ghichu
            // 
            this.ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 86);
            this.panel1.TabIndex = 76;
            // 
            // uc_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grB_Data);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "uc_TimKiem";
            this.Size = new System.Drawing.Size(1164, 567);
            this.Load += new System.EventHandler(this.uc_TimKiem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grB_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tênHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_TenHH;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txt_TenNCC;
        private System.Windows.Forms.GroupBox grB_Data;
        private System.Windows.Forms.DataGridView dtg_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Panel panel1;
    }
}
