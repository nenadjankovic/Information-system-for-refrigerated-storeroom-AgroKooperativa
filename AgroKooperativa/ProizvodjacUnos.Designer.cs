namespace AgroKooperativa
{
    partial class ProizvodjacUnos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProizvodjacUnos));
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblMesto = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblBPG = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtBPG = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.errIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errBPG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMesto = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(279, 147);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(214, 10);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(214, 35);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(214, 64);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(39, 13);
            this.lblMesto.TabIndex = 4;
            this.lblMesto.Text = "Mesto:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(214, 93);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblBPG
            // 
            this.lblBPG.AutoSize = true;
            this.lblBPG.Location = new System.Drawing.Point(214, 118);
            this.lblBPG.Name = "lblBPG";
            this.lblBPG.Size = new System.Drawing.Size(32, 13);
            this.lblBPG.TabIndex = 6;
            this.lblBPG.Text = "BPG:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(279, 11);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(279, 35);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(279, 64);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(100, 20);
            this.txtMesto.TabIndex = 10;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(279, 95);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtBPG
            // 
            this.txtBPG.Location = new System.Drawing.Point(279, 121);
            this.txtBPG.Name = "txtBPG";
            this.txtBPG.Size = new System.Drawing.Size(100, 20);
            this.txtBPG.TabIndex = 12;
            this.txtBPG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPG_KeyPress);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(279, 176);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // errIme
            // 
            this.errIme.ContainerControl = this;
            // 
            // errPrezime
            // 
            this.errPrezime.ContainerControl = this;
            // 
            // errTelefon
            // 
            this.errTelefon.ContainerControl = this;
            // 
            // errBPG
            // 
            this.errBPG.ContainerControl = this;
            // 
            // errMesto
            // 
            this.errMesto.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ProizvodjacUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtBPG);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblBPG);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblMesto);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnPotvrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProizvodjacUnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog proizvođača";
            this.Load += new System.EventHandler(this.ProizvodjacUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblBPG;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtBPG;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ErrorProvider errIme;
        private System.Windows.Forms.ErrorProvider errPrezime;
        private System.Windows.Forms.ErrorProvider errTelefon;
        private System.Windows.Forms.ErrorProvider errBPG;
        private System.Windows.Forms.ErrorProvider errMesto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}