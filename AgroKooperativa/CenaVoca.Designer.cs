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
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCenaVoca
            // 
            this.dgwCenaVoca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwCenaVoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCenaVoca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.CenaIKlase,
            this.CenaIIKlase,
            this.Datum});
            this.dgwCenaVoca.Location = new System.Drawing.Point(12, 12);
            this.dgwCenaVoca.Name = "dgwCenaVoca";
            this.dgwCenaVoca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwCenaVoca.Size = new System.Drawing.Size(374, 268);
            this.dgwCenaVoca.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv voća";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 86;
            // 
            // CenaIKlase
            // 
            this.CenaIKlase.DataPropertyName = "CenaIKlase";
            this.CenaIKlase.HeaderText = "Cena I klase";
            this.CenaIKlase.Name = "CenaIKlase";
            this.CenaIKlase.Width = 91;
            // 
            // CenaIIKlase
            // 
            this.CenaIIKlase.DataPropertyName = "CenaIIKlase";
            this.CenaIIKlase.HeaderText = "Cena II klase";
            this.CenaIIKlase.Name = "CenaIIKlase";
            this.CenaIIKlase.Width = 94;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Width = 63;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(456, 286);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
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
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmeni cenu";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(3, 108);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(178, 20);
            this.dtpDatum.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nova cena II klase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova cena I klase";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(52, 239);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 15;
            this.btnIzmeni.Text = "Izmeni cenu";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtCena2klase
            // 
            this.txtCena2klase.Location = new System.Drawing.Point(33, 213);
            this.txtCena2klase.Name = "txtCena2klase";
            this.txtCena2klase.Size = new System.Drawing.Size(134, 20);
            this.txtCena2klase.TabIndex = 14;
            // 
            // txtCena1klase
            // 
            this.txtCena1klase.Location = new System.Drawing.Point(33, 174);
            this.txtCena1klase.Name = "txtCena1klase";
            this.txtCena1klase.Size = new System.Drawing.Size(134, 20);
            this.txtCena1klase.TabIndex = 13;
            // 
            // cbVoce
            // 
            this.cbVoce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoce.FormattingEnabled = true;
            this.cbVoce.Location = new System.Drawing.Point(33, 58);
            this.cbVoce.Name = "cbVoce";
            this.cbVoce.Size = new System.Drawing.Size(134, 21);
            this.cbVoce.TabIndex = 12;
            // 
            // CenaVoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgwCenaVoca);
            this.Name = "CenaVoca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CenaVoca";
            this.Load += new System.EventHandler(this.CenaVoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCenaVoca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
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
    }
}