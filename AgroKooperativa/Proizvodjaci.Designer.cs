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
            this.btnObriši = new System.Windows.Forms.Button();
            this.lblUnesiID = new System.Windows.Forms.Label();
            this.txtIDzaBrisanje = new System.Windows.Forms.TextBox();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spisak proizvođača";
            // 
            // btnDodajProizvodjaca
            // 
            this.btnDodajProizvodjaca.Location = new System.Drawing.Point(507, 36);
            this.btnDodajProizvodjaca.Name = "btnDodajProizvodjaca";
            this.btnDodajProizvodjaca.Size = new System.Drawing.Size(75, 42);
            this.btnDodajProizvodjaca.TabIndex = 3;
            this.btnDodajProizvodjaca.Text = "Dodaj proizvođača";
            this.btnDodajProizvodjaca.UseVisualStyleBackColor = true;
            this.btnDodajProizvodjaca.Click += new System.EventHandler(this.btnDodajProizvodjaca_Click);
            // 
            // gbObrisi
            // 
            this.gbObrisi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbObrisi.Controls.Add(this.btnObriši);
            this.gbObrisi.Controls.Add(this.lblUnesiID);
            this.gbObrisi.Controls.Add(this.txtIDzaBrisanje);
            this.gbObrisi.Location = new System.Drawing.Point(479, 93);
            this.gbObrisi.Name = "gbObrisi";
            this.gbObrisi.Size = new System.Drawing.Size(137, 132);
            this.gbObrisi.TabIndex = 4;
            this.gbObrisi.TabStop = false;
            this.gbObrisi.Text = "Obriši proizvođača";
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(23, 95);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(75, 23);
            this.btnObriši.TabIndex = 2;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // lblUnesiID
            // 
            this.lblUnesiID.AutoSize = true;
            this.lblUnesiID.Location = new System.Drawing.Point(15, 27);
            this.lblUnesiID.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblUnesiID.Name = "lblUnesiID";
            this.lblUnesiID.Size = new System.Drawing.Size(98, 39);
            this.lblUnesiID.TabIndex = 1;
            this.lblUnesiID.Text = "Unesite ID proizvođača kojeg želite da obrišete:";
            // 
            // txtIDzaBrisanje
            // 
            this.txtIDzaBrisanje.Location = new System.Drawing.Point(18, 69);
            this.txtIDzaBrisanje.Name = "txtIDzaBrisanje";
            this.txtIDzaBrisanje.Size = new System.Drawing.Size(100, 20);
            this.txtIDzaBrisanje.TabIndex = 0;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(512, 244);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // Proizvodjaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 291);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.gbObrisi);
            this.Controls.Add(this.btnDodajProizvodjaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProizvodjaci);
            this.Name = "Proizvodjaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodjaci";
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
        private System.Windows.Forms.Label lblUnesiID;
        private System.Windows.Forms.TextBox txtIDzaBrisanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPG;
        private System.Windows.Forms.Button btnNazad;
    }
}