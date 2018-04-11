using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_KHO
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                conn.Open();

                string sql = "select *from TaiKhoan where acc = '" + txtUserName.Text.Trim() + "' and pass = '" + txtPassWord.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    Controller.ConnectDatabase.NameLogin = txtUserName.Text.Trim();

                    if (cbSaveInfo.Checked == true)
                    {
                        using (StreamWriter wr = new StreamWriter("info.ini"))
                        {
                            wr.WriteLine(txtUserName.Text.Trim());
                            wr.WriteLine(txtPassWord.Text.Trim());
                            wr.Close();
                        }
                    }
                    else
                    {
                        File.Delete("info.ini");
                    }
                     View.frmMain m = new View.frmMain();
                    this.Hide();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
