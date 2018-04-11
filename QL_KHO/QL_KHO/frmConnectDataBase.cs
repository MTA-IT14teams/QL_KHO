using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QL_KHO
{
    public partial class frmDangNhap_CSDL : Form
    {
        public frmDangNhap_CSDL()
        {
            InitializeComponent();
        }

        private void DangNhap_CSDL_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMK.Enabled = false;
        }

        private void cbxChonTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxChonTaiKhoan.SelectedIndex == 0)
            {
                Controller.ConnectDatabase.WindowAuthentication = true;
                txtTenDangNhap.Enabled = false;
                txtMK.Enabled = false;
            }
            else
            {
                Controller.ConnectDatabase.WindowAuthentication = false;
                txtTenDangNhap.Enabled = true;
                txtMK.Enabled = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenMayChu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tên máy chủ");
                ActiveControl = txtTenMayChu;
                return;
            }
            if(txtTenCSDL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên CSDL");
                ActiveControl = txtTenCSDL;
                return;
            }
            string connect = "";
            Controller.ConnectDatabase.SeverName = txtTenMayChu.Text.Trim();
            Controller.ConnectDatabase.DatabaseName = txtTenCSDL.Text.Trim();
            if(Controller.ConnectDatabase.WindowAuthentication == true)
            {
                Controller.ConnectDatabase.MakeConnectionString();
                connect = Controller.ConnectDatabase.ConnectionString;
            }
            else
            {
                if(txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên đăng nhập");
                    ActiveControl = txtTenDangNhap;
                    return;
                }
                if (txtMK.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu");
                    ActiveControl = txtMK;
                    return;
                }
                Controller.ConnectDatabase.UserName = txtTenDangNhap.Text.Trim();
                Controller.ConnectDatabase.PassWord = txtMK.Text.Trim();
                Controller.ConnectDatabase.MakeConnectionString();

                connect = Controller.ConnectDatabase.ConnectionString;
            }
            // show connect
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Kết nối thành công");
                    using (StreamWriter write = new StreamWriter("config"))
                    {
                        write.WriteLine(Controller.ConnectDatabase.SeverName);
                        write.WriteLine(Controller.ConnectDatabase.DatabaseName);
                        write.WriteLine(Controller.ConnectDatabase.UserName);
                        write.WriteLine(Controller.ConnectDatabase.PassWord);
                    }
                    frmDangNhap dangnhap = new frmDangNhap();                   
                    this.Hide();
                    dangnhap.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
