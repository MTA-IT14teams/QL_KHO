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
            this.grB_Title = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tênHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_TenHH = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_TenNCC = new System.Windows.Forms.ToolStripTextBox();
            this.grB_Data = new System.Windows.Forms.GroupBox();
            this.dtg_Data = new System.Windows.Forms.DataGridView();
            this.grB_Title.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grB_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // grB_Title
            // 
            this.grB_Title.Controls.Add(this.label1);
            this.grB_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.grB_Title.Location = new System.Drawing.Point(0, 0);
            this.grB_Title.Name = "grB_Title";
            this.grB_Title.Size = new System.Drawing.Size(658, 100);
            this.grB_Title.TabIndex = 0;
            this.grB_Title.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tênHàngHóaToolStripMenuItem,
            this.txt_TenHH});
            this.menuStrip1.Location = new System.Drawing.Point(4, 107);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 27);
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
            this.txt_TenHH.Size = new System.Drawing.Size(100, 23);
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
            this.menuStrip2.Size = new System.Drawing.Size(316, 27);
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
            this.txt_TenNCC.Size = new System.Drawing.Size(100, 23);
            this.txt_TenNCC.Click += new System.EventHandler(this.txt_TenNCC_Click);
            this.txt_TenNCC.TextChanged += new System.EventHandler(this.txt_TenNCC_TextChanged);
            // 
            // grB_Data
            // 
            this.grB_Data.Controls.Add(this.dtg_Data);
            this.grB_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grB_Data.Location = new System.Drawing.Point(0, 225);
            this.grB_Data.Name = "grB_Data";
            this.grB_Data.Size = new System.Drawing.Size(658, 342);
            this.grB_Data.TabIndex = 3;
            this.grB_Data.TabStop = false;
            // 
            // dtg_Data
            // 
            this.dtg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Data.Location = new System.Drawing.Point(3, 16);
            this.dtg_Data.Name = "dtg_Data";
            this.dtg_Data.Size = new System.Drawing.Size(652, 323);
            this.dtg_Data.TabIndex = 0;
            // 
            // uc_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grB_Data);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grB_Title);
            this.Controls.Add(this.menuStrip1);
            this.Name = "uc_TimKiem";
            this.Size = new System.Drawing.Size(658, 567);
            this.Load += new System.EventHandler(this.uc_TimKiem_Load);
            this.grB_Title.ResumeLayout(false);
            this.grB_Title.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grB_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tênHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_TenHH;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txt_TenNCC;
        private System.Windows.Forms.GroupBox grB_Data;
        private System.Windows.Forms.DataGridView dtg_Data;
    }
}
