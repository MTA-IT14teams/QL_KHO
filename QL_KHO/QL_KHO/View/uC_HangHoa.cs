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
    public partial class uC_HangHoa : UserControl
    {

        HangHoa HH = new HangHoa();
        HangHoa_controller HH_ctl = new HangHoa_controller();
        private int hanhdong = 1;

        public uC_HangHoa()
        {
            InitializeComponent();
        }

        private void dgvHangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHangHoa.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        // Mở button
        private void DisEnl(bool e)
        {
            btnthem.Enabled = !e;
            btnxoa.Enabled = !e;
            btnsua.Enabled = !e;
            btnluu.Enabled = e;
            txtMaHH.Enabled = e;
            txtTenHH.Enabled = e;
            txtSoLuong.Enabled = e;
            cbMaNCC.Enabled = e;       
        }

        // xóa trắng
        public void Clear()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            cbMaNCC.Text = "";
            
        }

        private void HienThi()
        {
            dgvHangHoa.DataSource = HH_ctl.GetData();
        }

        private void ShowTenNCC()
        {
            DataTable dt = new DataTable();
            dt = HH_ctl.GetTenHH();
            cbMaNCC.DataSource = dt;
            cbMaNCC.DisplayMember = "tenNCC";
            cbMaNCC.ValueMember = "maNCC";
        }

        // Hàm Load
        private void uC_HangHoa_Load(object sender, EventArgs e)
        {
            HienThi();
            ShowTenNCC();
            DisEnl(false);
        }

        // Xử lý trong dgv
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["maHH"].Value);
            txtTenHH.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["tenHH"].Value);
            txtSoLuong.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["soluong"].Value);
            cbMaNCC.Text = Convert.ToString(dgvHangHoa.CurrentRow.Cells["maNCC"].Value);
        }

        // Thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            hanhdong = 0;
            this.txtMaHH.Focus();
            Clear();
            DisEnl(true);
        }

        // Sửa 
        private void btnsua_Click(object sender, EventArgs e)
        {
            hanhdong = 1;
            DisEnl(true);
            txtMaHH.Enabled = false;
        }

        // Xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    HH_ctl.DeleteData(txtMaHH.Text);
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

        // Lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenHH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            HH.MaHH = txtMaHH.Text;
            HH.TenHH = txtTenHH.Text;
            HH.SoLuong = _soLuong;
            HH.MaNCC = cbMaNCC.SelectedValue.ToString();
            if (txtMaHH.Text != "" && txtTenHH.Text != "" && txtSoLuong.Text !="" && cbMaNCC.Text !="" && hanhdong == 0)
            {
                try
                {
                    HH_ctl.InsertData(HH);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    uC_HangHoa_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    hanhdong = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, không thêm được!" + ex.Message);
                }
            }

            else if (txtMaHH.Text != "" && txtTenHH.Text != "" && txtSoLuong.Text != "" && cbMaNCC.Text != "" && hanhdong != 0)
            {
                try
                {
                    HH_ctl.UpdateData(HH);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    uC_HangHoa_Load(sender, e);
                    Clear();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, không sửa được!!" + ex.Message);
                }
            }
        }

        // Thoát
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

        // Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã HH")
            {
                dgvHangHoa.DataSource = HH_ctl.TimKiemHH("select * from HangHoa  where maHH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên HH")
            {
                dgvHangHoa.DataSource = HH_ctl.TimKiemHH("select * from HangHoa where tenHH like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Mã NCC")
            {
                dgvHangHoa.DataSource = HH_ctl.TimKiemHH("select maHH, tenHH, NCC.maNCC, soluong from HangHoa, NCC where HangHoa.maNCC = NCC.maNCC  and maNCC Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Số lượng")
            {
                dgvHangHoa.DataSource = HH_ctl.TimKiemHH("select * from HangHoa where soluong like '%" + txtTimKiem.Text.Trim() + "%'");
            }            
        }
    }
}
