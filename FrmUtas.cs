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
    public partial class FrmUtas : Form
    {
        public FrmUtas(string uKod, string nev, string cim, string tKod)
        {
            InitializeComponent();
            tbUtasKod.Text = uKod;
            tbNev.Text = nev;
            rtbCim.Text = cim;
            cbJelentkezes.Text = tKod;
        }

        private void FrmUtas_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.utas;

            #region combo box
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                var kezd = Program.KamuDatum.ToString("yyyy-MM-01");
                var vege = Program.KamuDatum.AddMonths(2).ToString("yyyy-MM-01");

                conn.Open();
                var r = new SqlCommand(
                    "SELECT t_kod FROM tura " +
                    $"WHERE kezdet >= '{kezd}' AND kezdet < '{vege}';",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    cbJelentkezes.Items.Add(r[0]);
                }
            }
            #endregion
        }

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmUtasLista(true, this).ShowDialog();

        private void TsmiMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUtasKod.Text))
            {
                //insert
            }
            else
            {
                //update
            }
        }

        private void TsmiTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                text: "Bizti törölni szeretnéd?",
                caption: "TÖRLÉS",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //delete
                MezokTorlese();
            }
        }

        private void MezokTorlese()
        {
            tbUtasKod.Text = null;
            tbNev.Text = null;
            rtbCim.Text = null;
            cbJelentkezes.SelectedIndex = -1;
            cbJelentkezes.Text = null;
        }

        private void TsmiUresUrlap_Click(object sender, EventArgs e)
            => MezokTorlese();

        private void TbUtasKod_TextChanged(object sender, EventArgs e)
            => tsmiTorles.Enabled = !string.IsNullOrEmpty(tbUtasKod.Text);
    }
}
