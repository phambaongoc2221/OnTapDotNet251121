using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapDotNet251121
{
    public partial class FrmTK : Form
    {
        public FrmTK()
        {
            InitializeComponent();
        }

        KetNoiCSDL ketNoi = new KetNoiCSDL();
        DataTable dta = new DataTable();

        //combox thứ 2 trở lên
        /*private void BangNCC()
        {
            dta = connect_db.Lay_DulieuBang("Select * From nhaCungCap order by mancc");
            cboMaNCC.DataSource = dta;
            cboMaNCC.DisplayMember = "mancc";
            cboMaNCC.ValueMember = "mancc";
        }*/
        private void FrmTK_Load(object sender, EventArgs e)
        {
            DataTable dta = ketNoi.Lay_DulieuBang("SELECT * FROM LOP ORDER BY MALOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioMaLop.Checked == true)
            {
                sqltk = "SELECT * FROM LOP WHERE MALOP LIKE '" + cboMaLop.Text + "'";
                dta = ketNoi.Lay_DulieuBang(sqltk);
            }

            if (radioTenLop.Checked == true)
            {
                sqltk = "SELECT * FROM LOP WHERE TENLOP LIKE  '" + txtTenLop.Text + "'";
                dta = ketNoi.Lay_DulieuBang(sqltk);
            }


            DataGrid_LOP.DataSource = dta;
        }

        private void radioMaLop_CheckedChanged(object sender, EventArgs e)
        {
            cboMaLop.Focus();
            cboMaLop.Enabled = true;
            txtTenLop.Enabled = false;
        }

        private void radioTenLop_CheckedChanged(object sender, EventArgs e)
        {
            txtTenLop.Focus();
            txtTenLop.Enabled = true;
            cboMaLop.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
