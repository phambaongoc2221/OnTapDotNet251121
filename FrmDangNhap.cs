using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnTapDotNet251121
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ketNoiCSDL.KetNoi_Dulieu();

            string DN = txtTenDN.Text;
            string MK = txtMatKhau.Text;
            string sql_login = "SELECT TENDN, MATKHAU FROM HETHONG WHERE TENDN = '" + DN + "' AND MATKHAU = '" + MK + "'";

            SqlCommand cmd = new SqlCommand(sql_login, ketNoiCSDL.cnn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read() == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!");
                Form frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txtTenDN.Focus();
            }
        }
    }
}
