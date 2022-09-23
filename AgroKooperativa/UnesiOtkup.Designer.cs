namespace AgroKooperativa
{
    partial class UnesiOtkup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnesiOtkup));
            this.cbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVoce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicinaIKlase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicinaIIKlase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOtkup = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVraćeno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIzdato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnStanjeOtkupa = new System.Windows.Forms.Button();
            this.dgwOtkup = new System.Windows.Forms.DataGridView();
            this.idOtkupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivVoca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrutoIklasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrutoIIKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetoIKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetoIIKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdI = new System.Windows.Forms.RadioButton();
            this.rbII = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtIDBrisanje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtkup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProizvodjaci
            // 
            this.cbProizvodjaci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProizvodjaci.FormattingEnabled = true;
            this.cbProizvodjaci.Location = new System.Drawing.Point(26, 41);
            this.cbProizvodjaci.Name = "cbProizvodjaci";
            this.cbProizvodjaci.Size = new System.Drawing.Size(121, 21);
            this.cbProizvodjaci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvođač:";
            // 
            // cbVoce
            // 
            this.cbVoce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoce.FormattingEnabled = true;
            this.cbVoce.Location = new System.Drawing.Point(180, 41);
            this.cbVoce.Name = "cbVoce";
            this.cbVoce.Size = new System.Drawing.Size(121, 21);
            this.cbVoce.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voće:";
            // 
            // txtKolicinaIKlase
            // 
            this.txtKolicinaIKlase.Location = new System.Drawing.Point(26, 104);
            this.txtKolicinaIKlase.Name = "txtKolicinaIKlase";
            this.txtKolicinaIKlase.ShortcutsEnabled = false;
            this.txtKolicinaIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaIKlase.TabIndex = 4;
            this.txtKolicinaIKlase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicinaIKlase_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bruto količina I klase:";
            // 
            // txtKolicinaIIKlase
            // 
            this.txtKolicinaIIKlase.Location = new System.Drawing.Point(180, 104);
            this.txtKolicinaIIKlase.Name = "txtKolicinaIIKlase";
            this.txtKolicinaIIKlase.ShortcutsEnabled = false;
            this.txtKolicinaIIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaIIKlase.TabIndex = 6;
            this.txtKolicinaIIKlase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicinaIIKlase_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bruto količina II klase";
            // 
            // dtpOtkup
            // 
            this.dtpOtkup.Location = new System.Drawing.Point(26, 174);
            this.dtpOtkup.Name = "dtpOtkup";
            this.dtpOtkup.Size = new System.Drawing.Size(213, 20);
            this.dtpOtkup.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum otkupa:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Image = ((System.Drawing.Image)(resources.GetObject("btnUnesi.Image")));
            this.btnUnesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnesi.Location = new System.Drawing.Point(93, 317);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(95, 54);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Unesi otkup";
            this.btnUnesi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVraćeno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIzdato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(26, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ambalaža";
            // 
            // txtVraćeno
            // 
            this.txtVraćeno.Location = new System.Drawing.Point(25, 41);
            this.txtVraćeno.Name = "txtVraćeno";
            this.txtVraćeno.ShortcutsEnabled = false;
            this.txtVraćeno.Size = new System.Drawing.Size(100, 20);
            this.txtVraćeno.TabIndex = 3;
            this.txtVraćeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVraćeno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Izdato:";
            // 
            // txtIzdato
            // 
            this.txtIzdato.Location = new System.Drawing.Point(154, 41);
            this.txtIzdato.Name = "txtIzdato";
            this.txtIzdato.ShortcutsEnabled = false;
            this.txtIzdato.Size = new System.Drawing.Size(100, 20);
            this.txtIzdato.TabIndex = 1;
            this.txtIzdato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIzdato_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vraćeno:";
            // 
            // btnNazad
            // 
            this.btnNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnNazad.Image")));
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(15, 317);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(72, 54);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnStanjeOtkupa
            // 
            this.btnStanjeOtkupa.Image = ((System.Drawing.Image)(resources.GetObject("btnStanjeOtkupa.Image")));
            this.btnStanjeOtkupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStanjeOtkupa.Location = new System.Drawing.Point(194, 317);
            this.btnStanjeOtkupa.Name = "btnStanjeOtkupa";
            this.btnStanjeOtkupa.Size = new System.Drawing.Size(107, 54);
            this.btnStanjeOtkupa.TabIndex = 14;
            this.btnStanjeOtkupa.Text = "Stanje otkupa";
            this.btnStanjeOtkupa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStanjeOtkupa.UseVisualStyleBackColor = true;
            this.btnStanjeOtkupa.Click += new System.EventHandler(this.btnStanjeOtkupa_Click);
            // 
            // dgwOtkup
            // 
            this.dgwOtkup.AllowUserToAddRows = false;
            this.dgwOtkup.AllowUserToDeleteRows = false;
            this.dgwOtkup.AllowUserToResizeColumns = false;
            this.dgwOtkup.AllowUserToResizeRows = false;
            this.dgwOtkup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOtkup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOtkupa,
            this.Ime,
            this.Prezime,
            this.NazivVoca,
            this.BrutoIklasa,
            this.BrutoIIKlasa,
            this.NetoIKlasa,
            this.NetoIIKlasa,
            this.Tara,
            this.Datum});
            this.dgwOtkup.Location = new System.Drawing.Point(307, 25);
            this.dgwOtkup.Name = "dgwOtkup";
            this.dgwOtkup.RowHeadersVisible = false;
            this.dgwOtkup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwOtkup.Size = new System.Drawing.Size(638, 288);
            this.dgwOtkup.TabIndex = 15;
            // 
            // idOtkupa
            // 
            this.idOtkupa.DataPropertyName = "idOtkupa";
            this.idOtkupa.HeaderText = "ID";
            this.idOtkupa.Name = "idOtkupa";
            this.idOtkupa.Width = 40;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.Width = 70;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.Width = 80;
            // 
            // NazivVoca
            // 
            this.NazivVoca.DataPropertyName = "Naziv";
            this.NazivVoca.HeaderText = "Voće";
            this.NazivVoca.Name = "NazivVoca";
            this.NazivVoca.Width = 60;
            // 
            // BrutoIklasa
            // 
            this.BrutoIklasa.DataPropertyName = "BrutoKolicinaIKlase";
            this.BrutoIklasa.HeaderText = "Bruto I klasa";
            this.BrutoIklasa.Name = "BrutoIklasa";
            this.BrutoIklasa.Width = 60;
            // 
            // BrutoIIKlasa
            // 
            this.BrutoIIKlasa.DataPropertyName = "BrutoKolicinaIIKlase";
            this.BrutoIIKlasa.HeaderText = "Bruto II klasa";
            this.BrutoIIKlasa.Name = "BrutoIIKlasa";
            this.BrutoIIKlasa.Width = 60;
            // 
            // NetoIKlasa
            // 
            this.NetoIKlasa.DataPropertyName = "NetoKolicinaIKlase";
            this.NetoIKlasa.HeaderText = "Neto I klasa";
            this.NetoIKlasa.Name = "NetoIKlasa";
            this.NetoIKlasa.Width = 60;
            // 
            // NetoIIKlasa
            // 
            this.NetoIIKlasa.DataPropertyName = "NetoKolicinaIIKlase";
            this.NetoIIKlasa.HeaderText = "Neto II klasa";
            this.NetoIIKlasa.Name = "NetoIIKlasa";
            this.NetoIIKlasa.Width = 60;
            // 
            // Tara
            // 
            this.Tara.DataPropertyName = "Tara";
            this.Tara.HeaderText = "Tara";
            this.Tara.Name = "Tara";
            this.Tara.Width = 60;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // rdI
            // 
            this.rdI.AutoSize = true;
            this.rdI.Location = new System.Drawing.Point(26, 68);
            this.rdI.Name = "rdI";
            this.rdI.Size = new System.Drawing.Size(56, 17);
            this.rdI.TabIndex = 18;
            this.rdI.TabStop = true;
            this.rdI.Text = "I klasa";
            this.rdI.UseVisualStyleBackColor = true;
            this.rdI.CheckedChanged += new System.EventHandler(this.rdI_CheckedChanged);
            // 
            // rbII
            // 
            this.rbII.AutoSize = true;
            this.rbII.Location = new System.Drawing.Point(180, 68);
            this.rbII.Name = "rbII";
            this.rbII.Size = new System.Drawing.Size(59, 17);
            this.rbII.TabIndex = 19;
            this.rbII.TabStop = true;
            this.rbII.Text = "II klasa";
            this.rbII.UseVisualStyleBackColor = true;
            this.rbII.CheckedChanged += new System.EventHandler(this.rbII_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.txtIDBrisanje);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(312, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 51);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obriši otkup";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(367, 8);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 37);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtIDBrisanje
            // 
            this.txtIDBrisanje.Location = new System.Drawing.Point(255, 21);
            this.txtIDBrisanje.Name = "txtIDBrisanje";
            this.txtIDBrisanje.Size = new System.Drawing.Size(106, 20);
            this.txtIDBrisanje.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unesite ID otkupa kojeg želite da bude uklonite:";
            // 
            // UnesiOtkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbII);
            this.Controls.Add(this.rdI);
            this.Controls.Add(this.dgwOtkup);
            this.Controls.Add(this.btnStanjeOtkupa);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpOtkup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicinaIIKlase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKolicinaIKlase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVoce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProizvodjaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnesiOtkup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija otkupa";
            this.Load += new System.EventHandler(this.UnesiOtkup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtkup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProizvodjaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVoce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicinaIKlase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicinaIIKlase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOtkup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVraćeno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIzdato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnStanjeOtkupa;
        private System.Windows.Forms.DataGridView dgwOtkup;
        private System.Windows.Forms.RadioButton rdI;
        private System.Windows.Forms.RadioButton rbII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtIDBrisanje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtkupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivVoca;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrutoIklasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrutoIIKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetoIKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetoIIKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}