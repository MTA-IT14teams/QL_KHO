using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_KHO.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            uc_TrangChu a = new uc_TrangChu();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void TrangChu_Click(object sender, EventArgs e)
        {
            uc_TrangChu a = new uc_TrangChu();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_NhapHang a = new uc_NhapHang();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_XuatHang a = new uc_XuatHang();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_HangHoa a = new uC_HangHoa();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_NhaCungCap a = new uc_NhaCungCap();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_TimKiem a = new uc_TimKiem();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_ThongKe a = new uc_ThongKe();
            a.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(a);
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

    }
}
