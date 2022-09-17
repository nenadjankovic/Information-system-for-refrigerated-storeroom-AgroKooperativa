namespace AgroKooperativa
{
    partial class Proizvodjaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proizvodjaci));
            this.dgwProizvodjaci = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajProizvodjaca = new System.Windows.Forms.Button();
            this.gbObrisi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPr = new System.Windows.Forms.ComboBox();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProizvodjaci)).BeginInit();
            this.gbObrisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProizvodjaci
            // 
            this.dgwProizvodjaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProizvodjaci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwProizvodjaci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwProizvodjaci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwProizvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProizvodjaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Mesto,
            this.Telefon,
            this.BPG});
            this.dgwProizvodjaci.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwProizvodjaci.Location = new System.Drawing.Point(2, 25);
            this.dgwProizvodjaci.Name = "dgwProizvodjaci";
            this.dgwProizvodjaci.Size = new System.Drawing.Size(471, 257);
            this.dgwProizvodjaci.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idProizvodjaca";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.FillWeight = 80F;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.FillWeight = 95F;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Mesto
            // 
            this.Mesto.DataPropertyName = "Mesto";
            this.Mesto.FillWeight = 80F;
            this.Mesto.HeaderText = "Mesto";
            this.Mesto.Name = "Mesto";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.FillWeight = 90F;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // BPG
            // 
            this.BPG.DataPropertyName = "BPG";
            this.BPG.FillWeight = 101.7259F;
            this.BPG.HeaderText = "BPG";
            this.BPG.Name = "BPG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spisak proizvođača";
            // 
            // btnDodajProizvodjaca
            // 
            this.btnDodajProizvodjaca.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDodajProizvodjaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvodjaca.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajProizvodjaca.Image")));
            this.btnDodajProizvodjaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajProizvodjaca.Location = new System.Drawing.Point(501, 25);
            this.btnDodajProizvodjaca.Name = "btnDodajProizvodjaca";
            this.btnDodajProizvodjaca.Size = new System.Drawing.Size(162, 53);
            this.btnDodajProizvodjaca.TabIndex = 3;
            this.btnDodajProizvodjaca.Text = "Dodaj proizvođača";
            this.btnDodajProizvodjaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajProizvodjaca.UseVisualStyleBackColor = false;
            this.btnDodajProizvodjaca.Click += new System.EventHandler(this.btnDodajProizvodjaca_Click);
            // 
            // gbObrisi
            // 
            this.gbObrisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbObrisi.Controls.Add(this.label2);
            this.gbObrisi.Controls.Add(this.cbPr);
            this.gbObrisi.Controls.Add(this.btnObriši);
            this.gbObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbObrisi.ForeColor = System.Drawing.Color.Black;
            this.gbObrisi.Location = new System.Drawing.Point(479, 84);
            this.gbObrisi.Name = "gbObrisi";
            this.gbObrisi.Size = new System.Drawing.Size(205, 156);
            this.gbObrisi.TabIndex = 4;
            this.gbObrisi.TabStop = false;
            this.gbObrisi.Text = "Obriši proizvođača";
            this.gbObrisi.Enter += new System.EventHandler(this.gbObrisi_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite proizvođača";
            // 
            // cbPr
            // 
            this.cbPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPr.FormattingEnabled = true;
            this.cbPr.Location = new System.Drawing.Point(7, 66);
            this.cbPr.Name = "cbPr";
            this.cbPr.Size = new System.Drawing.Size(187, 21);
            this.cbPr.TabIndex = 3;
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnObriši.ForeColor = System.Drawing.Color.Black;
            this.btnObriši.Image = ((System.Drawing.Image)(resources.GetObject("btnObriši.Image")));
            this.btnObriši.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObriši.Location = new System.Drawing.Point(33, 104);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(140, 36);
            this.btnObriši.TabIndex = 2;
            this.btnObriši.Text = "Obriši proizvođača";
            this.btnObriši.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(528, 246);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(113, 33);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // Proizvodjaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 291);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.gbObrisi);
            this.Controls.Add(this.btnDodajProizvodjaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProizvodjaci);
            this.Name = "Proizvodjaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvođači";
            this.Load += new System.EventHandler(this.Proizvodjaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProizvodjaci)).EndInit();
            this.gbObrisi.ResumeLayout(false);
            this.gbObrisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProizvodjaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajProizvodjaca;
        private System.Windows.Forms.GroupBox gbObrisi;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPG;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPr;
    }
}