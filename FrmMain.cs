using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220114
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.logo;
            lblDatum.Text = $"{Program.KamuDatum.ToString("yyyy. MMMM dd.")}";

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT t_kod, hova, kezdet, vege, idegenvezeto.nev, szallas.nev, ar " +
                    "FROM tura " +
                    "INNER JOIN idegenvezeto ON vezeto = i_kod " +
                    "INNER JOIN szallas ON szallas = sz_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    //$"WHERE kezdet >= '{DateTime.Now.ToString("yyyy-MM-01")};'",
                    $"WHERE kezdet >= '{Program.KamuDatum.ToString("yyyy-MM-01")}';",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    dgvMain.Rows.Add(
                        r[0], r[1],
                        r.GetDateTime(2).ToString("yyyy.MM.dd."),
                        r.GetDateTime(3).ToString("yyyy.MM.dd."),
                        r[4], r[5], r[6]);
                }
            }
        }

        private void TsmiSzerkesztes_Click(object sender, EventArgs e)
            => new FrmUtas(null, null, null, null).ShowDialog();

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmUtasLista(false, null).ShowDialog();
    }
}
