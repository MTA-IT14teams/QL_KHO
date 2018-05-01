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
    public partial class ucNhapHang : UserControl
    {
        NhapHang NH = new NhapHang();
        NhapHang_Controller NH_ctl = new NhapHang_Controller();
        private int hanhdong = 1;
        public ucNhapHang()
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
        private void ucNhapHang_Load(object sender, EventArgs e)
        {
            DisEnl(false);
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
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int _soLuong;
            int _tongtien;
            int _dongia;
            DateTime _ngaynhap;
            int.TryParse(txtSoLuong.Text, out _soLuong);
            int.TryParse(txtTongTien.Text, out _tongtien);
            int.TryParse(txtDonGia.Text, out _dongia);
            DateTime.TryParse(dtpNgayNhap.Text, out _ngaynhap);
            NH.MaPN = txtMaPN.Text;
            dtpNgayNhap.Value = _ngaynhap;
            NH.TongTien = _tongtien;
            NH.MaCTN = txtMaCTN.Text;
            NH.MaHH = txtMaHH.Text;
            NH.SoLuong = _soLuong;
            NH.DonGia = _dongia;
            if (txtMaPN.Text != "" && txtTongTien.Text != "" && txtMaCTN.Text != "" && txtMaHH.Text != "" && txtSoLuong.Text != "" && txtDonGia.Text != "" && hanhdong == 0)
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                    //conn.Open();
                    NH_ctl.InsertData(NH);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    ucNhapHang_Load(sender, e);
                    SetNull();
                    DisEnl(false);
                    hanhdong = 1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                // HienThi();
            }
            else if (txtMaPN.Text != "" && txtTongTien.Text != "" && txtMaCTN.Text != "" && txtMaHH.Text != "" && txtSoLuong.Text != "" && txtDonGia.Text != "" && hanhdong != 0)
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                    //conn.Open();
                    NH_ctl.UpdateData(NH);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    ucNhapHang_Load(sender, e);
                    SetNull();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                //HienThi();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            DisEnl(false);
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


    }
}
