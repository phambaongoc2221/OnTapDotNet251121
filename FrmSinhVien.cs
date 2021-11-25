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
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        DataTable dta = new DataTable();

        private void BANG_SINHVIEN()
        {
          
            dta = ketNoiCSDL.Lay_DulieuBang("select * from SINHVIEN");
            DataGrid_SinhVien.DataSource = dta;
            
            HIENTHI_DULIEU();
        }
        private void BANG_KHOAVIEN()
        {
            dta = ketNoiCSDL.Lay_DulieuBang("select * from KHOAVIEN");
            cboMaKhoa.DataSource = dta;
            cboMaKhoa.DisplayMember = "MAKHOA";
            cboMaKhoa.ValueMember = "MAKHOA";
        }

        private void BANG_HEDAOTAO()
        {
            dta = ketNoiCSDL.Lay_DulieuBang("select * from HEDAOTAO");
            cboMaHe.DataSource = dta;
            cboMaHe.DisplayMember = "MAHE";
            cboMaHe.ValueMember = "MAHE";
        }

        private void BANG_LOP()
        {
            dta = ketNoiCSDL.Lay_DulieuBang("select * from LOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
        }


        private void HIENTHI_DULIEU()
        {

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MASV");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "HOTEN");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "GIOITINH");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "NGAYSINH");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "NOISINH");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MAKHOA");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MALOP");

            DataGrid_SinhVien.DataBindings.Clear();
            DataGrid_SinhVien.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MAHE");


        }
       

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            BANG_HEDAOTAO();
            BANG_KHOAVIEN();
            BANG_LOP();
            BANG_SINHVIEN();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            
            txtMaSV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select MASV from SINHVIEN where MASV = '" + txtMaSV.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, ketNoiCSDL.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Tài sản Sửa chữa này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaSV.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu;
                sql_luu = "insert into SINHVIEN values('" + txtMaSV.Text + "','" + txtHoTen.Text + "','" + txtGioiTinh.Text + "','" + txtNgaySinh.Text + "','" + txtNoiSinh.Text + "','" + cboMaKhoa.Text + "','" + cboMaLop.Text + "','" + cboMaHe.Text + "')";

                ketNoiCSDL.ThucThi(sql_luu);
                BANG_SINHVIEN();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua;
            sql_sua = "update SINHVIEN set HOTEN= '" + txtHoTen.Text + "', GIOITINH= '" + txtGioiTinh.Text + "', NGAYSINH = '" + txtNgaySinh.Text + "', NOISINH= '" + txtNoiSinh.Text + "', MAKHOA = '" + cboMaKhoa.Text + "', MALOP = '" + cboMaLop.Text + "', MAHE = '" + cboMaHe.Text + "' where MASV = '" + txtMaSV.Text + "'";

            ketNoiCSDL.ThucThi(sql_sua);
            BANG_SINHVIEN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa k ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa;
                sql_xoa = " delete SINHVIEN where MASV = '" + txtMaSV.Text + "'";

                ketNoiCSDL.ThucThi(sql_xoa);
                BANG_SINHVIEN();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
