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
    public partial class FrmBC_SV : Form
    {
        public FrmBC_SV()
        {
            InitializeComponent();
        }

        KetNoiCSDL ketNoi = new KetNoiCSDL();
        private void FrmBC_SV_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = ketNoi.Lay_DulieuBang("SELECT * FROM view_SV_TheoLop");
            BC_SV bC_SV = new BC_SV();
            bC_SV.SetDataSource(dta);
            CRV_SV.ReportSource = bC_SV;
        }
    }
}
