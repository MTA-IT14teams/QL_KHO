using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QL_KHO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sname = "";
            string dbname = "";
            string uname = "";
            string pass = "";

            if (!File.Exists("config"))
            {
                Application.Run(new frmDangNhap_CSDL());
            }
            else
            {
                using (StreamReader read = new StreamReader("config"))
                {
                    sname = read.ReadLine();
                    dbname = read.ReadLine();
                    uname = read.ReadLine();
                    pass = read.ReadLine();
                }

                Controller.ConnectDatabase.SeverName = sname;
                Controller.ConnectDatabase.DatabaseName = dbname;

                if (uname == null)
                {
                    Controller.ConnectDatabase.WindowAuthentication = true;
                    //DTO.ConnectDatabase.TaoChuoiKetNoi();
                }
                else
                {
                    Controller.ConnectDatabase.WindowAuthentication = true;
                }
                Controller.ConnectDatabase.MakeConnectionString();

                try
                {
                    SqlConnection conn = new SqlConnection(Controller.ConnectDatabase.ConnectionString);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        frmDangNhap lg = new frmDangNhap();
                        lg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại kết nối đến CSDL");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            Application.Run(new frmDangNhap_CSDL());
        }
    }
}
