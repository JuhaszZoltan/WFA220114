namespace WFA220114
{
    partial class FrmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiUtas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIdegenvezeto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzallas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtvonal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTura = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUtas,
            this.tsmiIdegenvezeto,
            this.tsmiSzallas,
            this.tsmiUtvonal,
            this.tsmiTura});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1063, 93);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiUtas
            // 
            this.tsmiUtas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerkesztes,
            this.tsmiKereses});
            this.tsmiUtas.Image = global::WFA220114.Properties.Resources.utas1;
            this.tsmiUtas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUtas.Name = "tsmiUtas";
            this.tsmiUtas.Size = new System.Drawing.Size(76, 89);
            this.tsmiUtas.Text = "Utas";
            this.tsmiUtas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzerkesztes
            // 
            this.tsmiSzerkesztes.Name = "tsmiSzerkesztes";
            this.tsmiSzerkesztes.Size = new System.Drawing.Size(180, 26);
            this.tsmiSzerkesztes.Text = "Szerkesztés";
            this.tsmiSzerkesztes.Click += new System.EventHandler(this.TsmiSzerkesztes_Click);
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(180, 26);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.Click += new System.EventHandler(this.TsmiKereses_Click);
            // 
            // tsmiIdegenvezeto
            // 
            this.tsmiIdegenvezeto.Image = global::WFA220114.Properties.Resources.idegenvezeto;
            this.tsmiIdegenvezeto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiIdegenvezeto.Name = "tsmiIdegenvezeto";
            this.tsmiIdegenvezeto.Size = new System.Drawing.Size(114, 89);
            this.tsmiIdegenvezeto.Text = "Idegenvezető";
            this.tsmiIdegenvezeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzallas
            // 
            this.tsmiSzallas.Image = global::WFA220114.Properties.Resources.szallas;
            this.tsmiSzallas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSzallas.Name = "tsmiSzallas";
            this.tsmiSzallas.Size = new System.Drawing.Size(76, 89);
            this.tsmiSzallas.Text = "Szállás";
            this.tsmiSzallas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiUtvonal
            // 
            this.tsmiUtvonal.Image = global::WFA220114.Properties.Resources.utvonal;
            this.tsmiUtvonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUtvonal.Name = "tsmiUtvonal";
            this.tsmiUtvonal.Size = new System.Drawing.Size(76, 89);
            this.tsmiUtvonal.Text = "Útvonal";
            this.tsmiUtvonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiTura
            // 
            this.tsmiTura.Image = global::WFA220114.Properties.Resources.tura;
            this.tsmiTura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTura.Name = "tsmiTura";
            this.tsmiTura.Size = new System.Drawing.Size(76, 89);
            this.tsmiTura.Text = "Túra";
            this.tsmiTura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMain.Location = new System.Drawing.Point(47, 176);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(979, 206);
            this.dgvMain.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kód";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cél";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kezdet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vége";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Idegenvezető";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Szállás";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ár (Ft)";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Túrák:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(43, 426);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(136, 20);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "###MaiDatum###";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 484);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Napos Oldal Utazási Iroda";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerkesztes;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiIdegenvezeto;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzallas;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtvonal;
        private System.Windows.Forms.ToolStripMenuItem tsmiTura;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

