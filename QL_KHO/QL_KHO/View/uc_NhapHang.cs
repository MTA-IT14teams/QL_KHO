﻿using System;
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
             cboMaHH.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
        }

        public void SetNull()
        {
            txtMaPN.Text = "";
            dtpNgayNhap.Text = "";
            txtTongTien.Text = "";
           // txtMaCTN.Text = "";
           cboMaHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }
        private void HienThi()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            dgvNhapHang.DataSource = NH_ctl.GetData();
            Show_HH();
        }
        private void Tongtien()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("XemNH1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPN", txtMaPN.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int sl = Convert.ToInt32(txtSoLuong.Text);
            int dongia = Convert.ToInt32(txtDonGia.Text);

            int tongtien = sl * dongia;
            txtTongTien.Text = tongtien.ToString();
        }

        private void Show_HH()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select maHH, tenHH from HangHoa", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.DisplayMember = "tenHH";
            cboMaHH.ValueMember = "maHH";
        }

        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
            conn.Open();
            string sql = "select pn.maPN, ngayNhap, tongTien, maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN = ct.maPN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "001";
            }
            else
            {
                int k;
                ma = "0";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                {
                    if(dt.Rows.Count<10)
                    {
                        ma = ma + "0";
                    }
                    else if(dt.Rows.Count<20)
                    {
                        ma = ma + "1";
                    }
                    else if (dt.Rows.Count < 30)
                    {
                        ma = ma + "2";
                    }
                    else if (dt.Rows.Count < 40)
                    {
                        ma = ma + "3";
                    }

                }
              
                ma = ma + k.ToString();
            }
           

            return ma;
        }
        private void uc_NhapHang_Load(object sender, EventArgs e)
        {
            DisEnl(false);
            HienThi();

        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Text = dgvNhapHang.CurrentRow.Cells["maPN"].Value.ToString();
            dtpNgayNhap.Text = dgvNhapHang.CurrentRow.Cells["ngayNhap"].Value.ToString();
            txtTongTien.Text = dgvNhapHang.CurrentRow.Cells["tongTien"].Value.ToString();

            cboMaHH.Text = dgvNhapHang.CurrentRow.Cells["maHH"].Value.ToString();
            txtSoLuong.Text = dgvNhapHang.CurrentRow.Cells["soLuong"].Value.ToString();
            txtDonGia.Text = dgvNhapHang.CurrentRow.Cells["donGia"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hanhdong = 0;
           
            SetNull();
            DisEnl(true);
           txtMaPN.Text = TangMa();
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
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHH", cboMaHH.SelectedValue);
                    cmd.Parameters.AddWithValue("@SLuong", txtSoLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm mới thành công");

                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mặt hàng --> Nhấn Refresh");
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
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                    cmd.Parameters.AddWithValue("@Tongtien", txtTongTien.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHH", cboMaHH.SelectedValue);
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
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien,maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and pn.maPN Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã CTN")
            {
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien, maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and maCTN Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cboTimKiem.Text == "Mã Hàng Hóa")
            {
                dgvNhapHang.DataSource = NH_ctl.TimKiemHH("select pn.maPN, ngayNhap, tongTien, maHH, soLuong, donGia from PhieuNhap pn, Chitietnhap ct where pn.maPN=ct.maPN and maHH Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void txtTongTien_MouseClick(object sender, MouseEventArgs e)
        {
            Tongtien();
        }

    }
}
