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
using System.Data.SqlClient;

namespace QL_KHO.View
{
    public partial class uc_XuatHang : UserControl
    {
        XuatHang XH = new XuatHang();
        XuatHang_Controller XH_ctl = new XuatHang_Controller();
        private int hanhdong = 1;
        public uc_XuatHang()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            txtMaPX.Enabled = e;
            dtpNgayXuat.Enabled = e;
            txtTongTien.Enabled = e;
            txtMaCTX.Enabled = e;
            txtMaHH.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
        }
        public void SetNull()
        {
            txtMaPX.Text = "";
            dtpNgayXuat.Text = "";
            txtTongTien.Text = "";
            txtMaCTX.Text = "";
            txtMaHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }
        private void HienThi()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            dgvXuatHang.DataSource = XH_ctl.GetData();
        }
        private void uc_XuatHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPX.Text = dgvXuatHang.CurrentRow.Cells["maPX"].Value.ToString();
            dtpNgayXuat.Text = dgvXuatHang.CurrentRow.Cells["ngayXuat"].Value.ToString();
            txtTongTien.Text = dgvXuatHang.CurrentRow.Cells["tongTien"].Value.ToString();
            txtMaCTX.Text = dgvXuatHang.CurrentRow.Cells["maCTX"].Value.ToString();
            //  cboDichVu.Text = dgvHoaDon.CurrentRow.Cells["MaDV"].Value.ToString();

            txtMaHH.Text = dgvXuatHang.CurrentRow.Cells["maHH"].Value.ToString();
            txtSoLuong.Text = dgvXuatHang.CurrentRow.Cells["soLuong"].Value.ToString();
            txtDonGia.Text = dgvXuatHang.CurrentRow.Cells["donGia"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hanhdong = 0;
            this.txtMaPX.Focus();
            SetNull();
            DisEnl(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hanhdong = 1;
            DisEnl(true);
            txtMaPX.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    XH_ctl.DeleteData(txtMaPX.Text);
                    MessageBox.Show("Xóa thành công!");
                    SetNull();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (hanhdong == 0)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThemXH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPX", txtMaPX.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayXuat", dtpNgayXuat.Value);

                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaCTX", txtMaCTX.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SLuong", txtSoLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm mới thành công");

                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }

            }
            else if (hanhdong == 1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaXH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPX", txtMaPX.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayXuat", dtpNgayXuat.Value);

                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaCTX", txtMaCTX.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@SLuong", txtSoLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa thành công");
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            DisEnl(false);
            btnLuu.Enabled = true;
            HienThi();
        }

       

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Mã Phiếu Xuất")
            {
                dgvXuatHang.DataSource = XH_ctl.TimKiemHH("select px.maPX, ngayXuat, tongTien, maCTX, maHH, soLuong, donGia from PhieuXuat px, Chitietxuat ct where px.maPX=ct.maPX and px.maPX Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã CTX")
            {
                dgvXuatHang.DataSource = XH_ctl.TimKiemHH("select px.maPX, ngayXuat, tongTien, maCTX, maHH, soLuong, donGia from PhieuXuat px, Chitietxuat ct where px.maPX=ct.maPX and maCTX Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã Hàng Hóa")
            {
                dgvXuatHang.DataSource = XH_ctl.TimKiemHH("select px.maPX, ngayXuat, tongTien, maCTX, maHH, soLuong, donGia from PhieuXuat px, Chitietxuat ct where px.maPX=ct.maPX and maHH Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
    }
}
