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
        public FrmUtas()
        {
            InitializeComponent();
        }

        private void FrmUtas_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.utas;

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
        }
    }
}
