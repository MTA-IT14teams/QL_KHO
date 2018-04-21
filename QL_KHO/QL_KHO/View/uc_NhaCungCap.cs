using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_KHO.Controller;
using QL_KHO.Model;


namespace QL_KHO.View
{
    public partial class uc_NhaCungCap : UserControl
    {
        private int hanhdong = 1;
        NhaCungCap NCC = new NhaCungCap();
        NCC_Controller NCC_ctl = new NCC_Controller();
        public uc_NhaCungCap()
        {
            InitializeComponent();
        }

        private void dgvNhaCungCap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhaCungCap.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        // Mở button
        private void DisEnl(bool e)
        {
            btnthem.Enabled = !e;
            btnxoa.Enabled = !e;
            btnsua.Enabled = !e;
            btnluu.Enabled = e;
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtEmail.Enabled = e;
        }

        // xóa trắng
        public void Clear()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void HienThi()
        {
            dgvNhaCungCap.DataSource = NCC_ctl.GetData();
        }

        private void uc_NhaCungCap_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false); // chỉ cho hiển thị k cho nhập
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = Convert.ToString(dgvNhaCungCap.CurrentRow.Cells["maNCC"].Value);
            txtTenNCC.Text = Convert.ToString(dgvNhaCungCap.CurrentRow.Cells["tenNCC"].Value);
            txtDiaChi.Text = Convert.ToString(dgvNhaCungCap.CurrentRow.Cells["diaChi"].Value);
            txtSDT.Text = Convert.ToString(dgvNhaCungCap.CurrentRow.Cells["SDT"].Value);
            txtEmail.Text = Convert.ToString(dgvNhaCungCap.CurrentRow.Cells["email"].Value);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            hanhdong = 0;
            this.txtMaNCC.Focus();
            Clear();
            DisEnl(true);
            //txtMaNCC.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hanhdong = 1;
            DisEnl(true);
            txtMaNCC.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NCC.MaNCC = txtMaNCC.Text;
            NCC.TenNCC = txtTenNCC.Text;
            NCC.DiaChi = txtDiaChi.Text;
            NCC.sdt = txtSDT.Text;
            NCC.Email = txtEmail.Text;
            if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" && hanhdong == 0)
            {
                try
                {
                    NCC_ctl.InsertData(NCC);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    uc_NhaCungCap_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    hanhdong = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }

            }
            else if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" && hanhdong != 0)
            {
                try
                {
                    NCC_ctl.UpdateData(NCC);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    uc_NhaCungCap_Load(sender, e);
                    Clear();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NCC_ctl.DeleteData(txtMaNCC.Text);
                    MessageBox.Show("Xóa thành công!");
                    Clear();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
            else
                HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã NCC")
            {
                dgvNhaCungCap.DataSource = NCC_ctl.TimKiemNCC("select * from NCC where maNCC like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên NCC")
            {
                dgvNhaCungCap.DataSource = NCC_ctl.TimKiemNCC("select * from NCC where tenNCC like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Địa chỉ")
            {
                dgvNhaCungCap.DataSource = NCC_ctl.TimKiemNCC("select * from NCC where diaChi Like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvNhaCungCap.DataSource = NCC_ctl.TimKiemNCC("select * from NCC where SDT like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Email")
            {
                dgvNhaCungCap.DataSource = NCC_ctl.TimKiemNCC("select * from NCC where email like '%" + txtTimKiem.Text.Trim() + "%'");
            }

        }
    }
}
