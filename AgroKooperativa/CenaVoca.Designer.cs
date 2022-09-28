namespace AgroKooperativa
{
    partial class CenaVoca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenaVoca));
            this.dgwCenaVoca = new System.Windows.Forms.DataGridView();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtCena2klase = new System.Windows.Forms.TextBox();
            this.txtCena1klase = new System.Windows.Forms.TextBox();
            this.cbVoce = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNovaCena = new System.Windows.Forms.DateTimePicker();
            this.txtNovaCenaII = new System.Windows.Forms.TextBox();
            this.txtNovaCenaI = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbDodajCenu = new System.Windows.Forms.ComboBox();
            this.btnVoce = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCenaVoca
            // 
            this.dgwCenaVoca.AllowUserToAddRows = false;
            this.dgwCenaVoca.AllowUserToDeleteRows = false;
            this.dgwCenaVoca.AllowUserToResizeColumns = false;
            this.dgwCenaVoca.AllowUserToResizeRows = false;
            this.dgwCenaVoca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwCenaVoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCenaVoca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.CenaIKlase,
            this.CenaIIKlase,
            this.Datum});
            this.dgwCenaVoca.Location = new System.Drawing.Point(230, 12);
            this.dgwCenaVoca.Name = "dgwCenaVoca";
            this.dgwCenaVoca.ReadOnly = true;
            this.dgwCenaVoca.RowHeadersVisible = false;
            this.dgwCenaVoca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwCenaVoca.Size = new System.Drawing.Size(331, 179);
            this.dgwCenaVoca.TabIndex = 0;
            // 
            // btnNazad
            // 
            this.btnNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnNazad.Image")));
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(18, 279);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(69, 30);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.txtCena2klase);
            this.groupBox1.Controls.Add(this.txtCena1klase);
            this.groupBox1.Controls.Add(this.cbVoce);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 261);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmeni cenu";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(3, 99);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(178, 20);
            this.dtpDatum.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nova cena II klase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova cena I klase";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Image = ((System.Drawing.Image)(resources.GetObject("btnIzmeni.Image")));
            this.btnIzmeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeni.Location = new System.Drawing.Point(49, 227);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(90, 23);
            this.btnIzmeni.TabIndex = 15;
            this.btnIzmeni.Text = "Izmeni cene";
            this.btnIzmeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtCena2klase
            // 
            this.txtCena2klase.Location = new System.Drawing.Point(33, 201);
            this.txtCena2klase.Name = "txtCena2klase";
            this.txtCena2klase.ShortcutsEnabled = false;
            this.txtCena2klase.Size = new System.Drawing.Size(134, 20);
            this.txtCena2klase.TabIndex = 14;
            this.txtCena2klase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCena2klase_KeyPress);
            // 
            // txtCena1klase
            // 
            this.txtCena1klase.Location = new System.Drawing.Point(33, 147);
            this.txtCena1klase.Name = "txtCena1klase";
            this.txtCena1klase.ShortcutsEnabled = false;
            this.txtCena1klase.Size = new System.Drawing.Size(134, 20);
            this.txtCena1klase.TabIndex = 13;
            this.txtCena1klase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCena1klase_KeyPress);
            // 
            // cbVoce
            // 
            this.cbVoce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoce.FormattingEnabled = true;
            this.cbVoce.Location = new System.Drawing.Point(6, 72);
            this.cbVoce.Name = "cbVoce";
            this.cbVoce.Size = new System.Drawing.Size(175, 21);
            this.cbVoce.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpNovaCena);
            this.groupBox2.Controls.Add(this.txtNovaCenaII);
            this.groupBox2.Controls.Add(this.txtNovaCenaI);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Controls.Add(this.cbDodajCenu);
            this.groupBox2.Location = new System.Drawing.Point(224, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj cenu voća";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena II klase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena I klase";
            // 
            // dtpNovaCena
            // 
            this.dtpNovaCena.Location = new System.Drawing.Point(153, 45);
            this.dtpNovaCena.Name = "dtpNovaCena";
            this.dtpNovaCena.Size = new System.Drawing.Size(200, 20);
            this.dtpNovaCena.TabIndex = 4;
            // 
            // txtNovaCenaII
            // 
            this.txtNovaCenaII.Location = new System.Drawing.Point(112, 85);
            this.txtNovaCenaII.Name = "txtNovaCenaII";
            this.txtNovaCenaII.Size = new System.Drawing.Size(100, 20);
            this.txtNovaCenaII.TabIndex = 3;
            // 
            // txtNovaCenaI
            // 
            this.txtNovaCenaI.Location = new System.Drawing.Point(6, 85);
            this.txtNovaCenaI.Name = "txtNovaCenaI";
            this.txtNovaCenaI.Size = new System.Drawing.Size(100, 20);
            this.txtNovaCenaI.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(249, 82);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj cenu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbDodajCenu
            // 
            this.cbDodajCenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDodajCenu.FormattingEnabled = true;
            this.cbDodajCenu.Location = new System.Drawing.Point(6, 45);
            this.cbDodajCenu.Name = "cbDodajCenu";
            this.cbDodajCenu.Size = new System.Drawing.Size(142, 21);
            this.cbDodajCenu.TabIndex = 0;
            // 
            // btnVoce
            // 
            this.btnVoce.Image = ((System.Drawing.Image)(resources.GetObject("btnVoce.Image")));
            this.btnVoce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoce.Location = new System.Drawing.Point(110, 279);
            this.btnVoce.Name = "btnVoce";
            this.btnVoce.Size = new System.Drawing.Size(69, 30);
            this.btnVoce.TabIndex = 5;
            this.btnVoce.Text = "Voće";
            this.btnVoce.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoce.UseVisualStyleBackColor = true;
            this.btnVoce.Click += new System.EventHandler(this.btnVoce_Click);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv voća";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 86;
            // 
            // CenaIKlase
            // 
            this.CenaIKlase.DataPropertyName = "CenaIKlase";
            this.CenaIKlase.HeaderText = "Cena I klase";
            this.CenaIKlase.Name = "CenaIKlase";
            this.CenaIKlase.ReadOnly = true;
            this.CenaIKlase.Width = 91;
            // 
            // CenaIIKlase
            // 
            this.CenaIIKlase.DataPropertyName = "CenaIIKlase";
            this.CenaIIKlase.HeaderText = "Cena II klase";
            this.CenaIIKlase.Name = "CenaIIKlase";
            this.CenaIIKlase.ReadOnly = true;
            this.CenaIIKlase.Width = 94;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 63;
            // 
            // CenaVoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 313);
            this.Controls.Add(this.btnVoce);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgwCenaVoca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CenaVoca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cene voća";
            this.Load += new System.EventHandler(this.CenaVoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtCena2klase;
        private System.Windows.Forms.TextBox txtCena1klase;
        private System.Windows.Forms.ComboBox cbVoce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDodajCenu;
        private System.Windows.Forms.DateTimePicker dtpNovaCena;
        private System.Windows.Forms.TextBox txtNovaCenaII;
        private System.Windows.Forms.TextBox txtNovaCenaI;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgwCenaVoca;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}