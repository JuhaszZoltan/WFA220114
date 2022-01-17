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
    public partial class FrmUtasLista : Form
    {
        public FrmUtasLista()
        {
            InitializeComponent();
        }

        private void FrmUtasLista_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.utas;
            Lekerdezes();           
        }

        private void Lekerdezes()
        {
            dgvUtasLista.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT u_kod, nev, cim, t_kod, kezdet, hova " +
                    "FROM utas " +
                    "INNER JOIN tura ON jelentkezik = t_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    $"WHERE nev LIKE '{tbNevSzures.Text}%' " +
                    $"AND hova LIKE '{tbCelSzures.Text}%' " +
                    $"ORDER BY nev, kezdet;",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    dgvUtasLista.Rows.Add(
                        r[0], r[1], r[2], r[3],
                        r.GetDateTime(4).ToString("yyyy. MM. dd."),
                        r[5]);
                }
            }
        }

        private void TbNevSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();

        private void TbCelSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();
    }
}
