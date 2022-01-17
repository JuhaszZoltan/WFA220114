namespace WFA220114
{
    partial class FrmUtas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msUtas = new System.Windows.Forms.MenuStrip();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUresUrlap = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.cbJelentkezes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUtasKod = new System.Windows.Forms.TextBox();
            this.msUtas.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUtas
            // 
            this.msUtas.Dock = System.Windows.Forms.DockStyle.Right;
            this.msUtas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msUtas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKereses,
            this.tsmiMentes,
            this.tsmiTorles,
            this.tsmiUresUrlap});
            this.msUtas.Location = new System.Drawing.Point(473, 0);
            this.msUtas.Name = "msUtas";
            this.msUtas.Padding = new System.Windows.Forms.Padding(9, 30, 0, 3);
            this.msUtas.Size = new System.Drawing.Size(105, 336);
            this.msUtas.TabIndex = 0;
            this.msUtas.Text = "menuStrip1";
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::WFA220114.Properties.Resources.keres;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(95, 61);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiMentes
            // 
            this.tsmiMentes.Image = global::WFA220114.Properties.Resources.ment;
            this.tsmiMentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMentes.Name = "tsmiMentes";
            this.tsmiMentes.Size = new System.Drawing.Size(95, 61);
            this.tsmiMentes.Text = "Mentés";
            this.tsmiMentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiTorles
            // 
            this.tsmiTorles.Image = global::WFA220114.Properties.Resources.delete;
            this.tsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTorles.Name = "tsmiTorles";
            this.tsmiTorles.Size = new System.Drawing.Size(95, 61);
            this.tsmiTorles.Text = "Törlés";
            this.tsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiUresUrlap
            // 
            this.tsmiUresUrlap.Image = global::WFA220114.Properties.Resources.ures;
            this.tsmiUresUrlap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUresUrlap.Name = "tsmiUresUrlap";
            this.tsmiUresUrlap.Size = new System.Drawing.Size(95, 61);
            this.tsmiUresUrlap.Text = "Üres Űrlap";
            this.tsmiUresUrlap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(152, 92);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(254, 26);
            this.tbNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Utas kód:";
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(151, 147);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(255, 96);
            this.rtbCim.TabIndex = 3;
            this.rtbCim.Text = "";
            // 
            // cbJelentkezes
            // 
            this.cbJelentkezes.FormattingEnabled = true;
            this.cbJelentkezes.Location = new System.Drawing.Point(152, 271);
            this.cbJelentkezes.Name = "cbJelentkezes";
            this.cbJelentkezes.Size = new System.Drawing.Size(111, 28);
            this.cbJelentkezes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jelentkezés:";
            // 
            // tbUtasKod
            // 
            this.tbUtasKod.Enabled = false;
            this.tbUtasKod.Location = new System.Drawing.Point(152, 37);
            this.tbUtasKod.Name = "tbUtasKod";
            this.tbUtasKod.Size = new System.Drawing.Size(111, 26);
            this.tbUtasKod.TabIndex = 1;
            // 
            // FrmUtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 336);
            this.Controls.Add(this.cbJelentkezes);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUtasKod);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.msUtas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msUtas;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUtas";
            this.Text = "Utas";
            this.Load += new System.EventHandler(this.FrmUtas_Load);
            this.msUtas.ResumeLayout(false);
            this.msUtas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUtas;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiMentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem tsmiUresUrlap;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbCim;
        private System.Windows.Forms.ComboBox cbJelentkezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUtasKod;
    }
}