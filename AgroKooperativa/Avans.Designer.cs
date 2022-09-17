namespace AgroKooperativa
{
    partial class Avans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avans));
            this.dgwAvans = new System.Windows.Forms.DataGridView();
            this.idavans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.cbProiz = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpAvans = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIzmeni = new System.Windows.Forms.DateTimePicker();
            this.cbPrIzmeni = new System.Windows.Forms.ComboBox();
            this.txtSumaIzmeni = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnObriši = new System.Windows.Forms.Button();
            this.txtIDObrisi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnUcitajUk = new System.Windows.Forms.Button();
            this.lblUkAvansa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPRpojedinacno = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAvans
            // 
            this.dgwAvans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAvans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idavans,
            this.Ime,
            this.Prezime,
            this.Datum,
            this.Suma});
            this.dgwAvans.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwAvans.Location = new System.Drawing.Point(12, 22);
            this.dgwAvans.Name = "dgwAvans";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgwAvans.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAvans.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwAvans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwAvans.Size = new System.Drawing.Size(427, 362);
            this.dgwAvans.TabIndex = 0;
            // 
            // idavans
            // 
            this.idavans.DataPropertyName = "idAvans";
            this.idavans.HeaderText = "ID";
            this.idavans.Name = "idavans";
            this.idavans.Width = 40;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Width = 72;
            // 
            // Suma
            // 
            this.Suma.DataPropertyName = "Suma";
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(47, 105);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(121, 20);
            this.txtSuma.TabIndex = 1;
            this.txtSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuma_KeyPress);
            // 
            // cbProiz
            // 
            this.cbProiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProiz.FormattingEnabled = true;
            this.cbProiz.Location = new System.Drawing.Point(47, 30);
            this.cbProiz.Name = "cbProiz";
            this.cbProiz.Size = new System.Drawing.Size(121, 21);
            this.cbProiz.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(58, 131);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 26);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj avans";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpAvans
            // 
            this.dtpAvans.Location = new System.Drawing.Point(11, 57);
            this.dtpAvans.Name = "dtpAvans";
            this.dtpAvans.Size = new System.Drawing.Size(200, 20);
            this.dtpAvans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proizvođač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suma:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpAvans);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cbProiz);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Location = new System.Drawing.Point(445, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj avans";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpIzmeni);
            this.groupBox2.Controls.Add(this.cbPrIzmeni);
            this.groupBox2.Controls.Add(this.txtSumaIzmeni);
            this.groupBox2.Location = new System.Drawing.Point(445, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 193);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmeni avans";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIzmeni.Image = ((System.Drawing.Image)(resources.GetObject("btnIzmeni.Image")));
            this.btnIzmeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeni.Location = new System.Drawing.Point(47, 166);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(121, 28);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni avans";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID avansa:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(47, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 7;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Proizvođač:";
            // 
            // dtpIzmeni
            // 
            this.dtpIzmeni.Location = new System.Drawing.Point(13, 103);
            this.dtpIzmeni.Name = "dtpIzmeni";
            this.dtpIzmeni.Size = new System.Drawing.Size(200, 20);
            this.dtpIzmeni.TabIndex = 4;
            // 
            // cbPrIzmeni
            // 
            this.cbPrIzmeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrIzmeni.FormattingEnabled = true;
            this.cbPrIzmeni.Location = new System.Drawing.Point(47, 76);
            this.cbPrIzmeni.Name = "cbPrIzmeni";
            this.cbPrIzmeni.Size = new System.Drawing.Size(121, 21);
            this.cbPrIzmeni.TabIndex = 2;
            // 
            // txtSumaIzmeni
            // 
            this.txtSumaIzmeni.Location = new System.Drawing.Point(47, 142);
            this.txtSumaIzmeni.Name = "txtSumaIzmeni";
            this.txtSumaIzmeni.Size = new System.Drawing.Size(121, 20);
            this.txtSumaIzmeni.TabIndex = 1;
            this.txtSumaIzmeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumaIzmeni_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnObriši);
            this.groupBox3.Controls.Add(this.txtIDObrisi);
            this.groupBox3.Location = new System.Drawing.Point(445, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obriši avans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID avansa:";
            // 
            // btnObriši
            // 
            this.btnObriši.Image = ((System.Drawing.Image)(resources.GetObject("btnObriši.Image")));
            this.btnObriši.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObriši.Location = new System.Drawing.Point(75, 62);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(63, 23);
            this.btnObriši.TabIndex = 1;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // txtIDObrisi
            // 
            this.txtIDObrisi.Location = new System.Drawing.Point(47, 36);
            this.txtIDObrisi.Name = "txtIDObrisi";
            this.txtIDObrisi.ShortcutsEnabled = false;
            this.txtIDObrisi.Size = new System.Drawing.Size(121, 20);
            this.txtIDObrisi.TabIndex = 0;
            this.txtIDObrisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDObrisi_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.btnNazad);
            this.groupBox4.Controls.Add(this.btnUcitajUk);
            this.groupBox4.Controls.Add(this.lblUkAvansa);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbPRpojedinacno);
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 101);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pregled avansa pojedinačno";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(6, 78);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(64, 23);
            this.btnNazad.TabIndex = 11;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnUcitajUk
            // 
            this.btnUcitajUk.Location = new System.Drawing.Point(260, 25);
            this.btnUcitajUk.Name = "btnUcitajUk";
            this.btnUcitajUk.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajUk.TabIndex = 3;
            this.btnUcitajUk.Text = "Prikaži";
            this.btnUcitajUk.UseVisualStyleBackColor = true;
            this.btnUcitajUk.Click += new System.EventHandler(this.btnUcitajUk_Click);
            // 
            // lblUkAvansa
            // 
            this.lblUkAvansa.AutoSize = true;
            this.lblUkAvansa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkAvansa.Location = new System.Drawing.Point(194, 51);
            this.lblUkAvansa.Name = "lblUkAvansa";
            this.lblUkAvansa.Size = new System.Drawing.Size(0, 25);
            this.lblUkAvansa.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ukupno avansa:";
            // 
            // cbPRpojedinacno
            // 
            this.cbPRpojedinacno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRpojedinacno.FormattingEnabled = true;
            this.cbPRpojedinacno.Location = new System.Drawing.Point(68, 27);
            this.cbPRpojedinacno.Name = "cbPRpojedinacno";
            this.cbPRpojedinacno.Size = new System.Drawing.Size(186, 21);
            this.cbPRpojedinacno.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Avans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 494);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwAvans);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Avans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avans";
            this.Load += new System.EventHandler(this.Avans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAvans;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.ComboBox cbProiz;
        private System.Windows.Forms.DateTimePicker dtpAvans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIzmeni;
        private System.Windows.Forms.ComboBox cbPrIzmeni;
        private System.Windows.Forms.TextBox txtSumaIzmeni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn idavans;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.TextBox txtIDObrisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUcitajUk;
        private System.Windows.Forms.Label lblUkAvansa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPRpojedinacno;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}