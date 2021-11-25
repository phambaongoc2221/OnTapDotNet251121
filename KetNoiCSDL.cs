using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnTapDotNet251121
{
    class KetNoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;



        public void KetNoi_Dulieu()
        {
            string str = @"Data Source=DESKTOP-HG3P3LE\SQLEXPRESS;Initial Catalog=OnTapDotNet251121;Integrated Security=True";
            cnn = new SqlConnection(str);
            cnn.Open();
        }



        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }



        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();

        }
    }
}
