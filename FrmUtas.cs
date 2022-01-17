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
            this.Icon = Properties.Resources.logo;

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT t_kod FROM tura " +
                    //$"WHERE kezdet >= '{DateTime.Now.ToString("yyyy-MM-01")};'",
                    $"WHERE kezdet >= '{Program.KamuDatum.ToString("yyyy-MM")}' AND ;",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    cbJelentkezes.Items.Add(r[0]);
                }
            }
        }
    }
}
