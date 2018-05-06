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
    public partial class uc_NhapHang : UserControl
    {
        NhapHang NH = new NhapHang();
        NhapHang_Controller NH_ctl = new NhapHang_Controller();
        private int hanhdong = 1;
        public uc_NhapHang()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            txtMaPN.Enabled = e;
            dtpNgayNhap.Enabled = e;
            txtTongTien.Enabled = e;
            txtMaCTN.Enabled = e;
            txtMaHH.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
        }

        public void SetNull()
        {
            txtMaPN.Text = "";
            dtpNgayNhap.Text = "";
            txtTongTien.Text = "";
            txtMaCTN.Text = "";
            txtMaHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }
        private void HienThi()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            dgvNhapHang.DataSource = NH_ctl.GetData();
        }
        //private void Tongtien()
        //{
        //    SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("XemNH1", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@MaPN", txtMaPN.Text.Trim());
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    int sl = Convert.ToInt32(txtSoLuong.Text);
        //    int dongia = Convert.ToInt32(txtDonGia.Text);

        //    int tongtien = sl * dongia;
        //    txtTongTien.Text = tongtien.ToString();
        //}

        private void uc_NhapHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Text = dgvNhapHang.CurrentRow.Cells["maPN"].Value.ToString();
            dtpNgayNhap.Text = dgvNhapHang.CurrentRow.Cells["ngayNhap"].Value.ToString();
            txtTongTien.Text = dgvNhapHang.CurrentRow.Cells["tongTien"].Value.ToString();
            txtMaCTN.Text = dgvNhapHang.CurrentRow.Cells["maCTN"].Value.ToString();
            //  cboDichVu.Text = dgvHoaDon.CurrentRow.Cells["MaDV"].Value.ToString();

            txtMaHH.Text = dgvNhapHang.CurrentRow.Cells["maHH"].Value.ToString();
            txtSoLuong.Text = dgvNhapHang.CurrentRow.Cells["soLuong"].Value.ToString();
            txtDonGia.Text = dgvNhapHang.CurrentRow.Cells["donGia"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hanhdong = 0;
            this.txtMaPN.Focus();
            SetNull();
            DisEnl(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hanhdong = 1;
            DisEnl(true);
            txtMaPN.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NH_ctl.DeleteData(txtMaPN.Text);
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
                    SqlCommand cmd = new SqlCommand("ThemNH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPN", txtMaPN.Text.Trim());
                    ////cmd.Parameters.AddWithValue("@Madv", txtMaDV.Text.Trim());//
                    // cmd.Parameters.AddWithValue("@Madv", cboDichVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);

                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaCTN", txtMaCTN.Text.Trim());
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
                    SqlCommand cmd = new SqlCommand("SuaNH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPN", txtMaPN.Text.Trim());
                    ////cmd.Parameters.AddWithValue("@Madv", txtMaDV.Text.Trim());//
                    // cmd.Parameters.AddWithValue("@Madv", cboDichVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);

                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaCTN", txtMaCTN.Text.Trim());
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Mã Phiếu Nhập")
            {
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien, maCTN,maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and pn.maPN Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã CTN")
            {
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien, maCTN,maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and maCTN Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã Hàng Hóa")
            {
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien, maCTN,maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and maHH Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        //private void txtTongTien_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Tongtien();
        //}
    }
}
