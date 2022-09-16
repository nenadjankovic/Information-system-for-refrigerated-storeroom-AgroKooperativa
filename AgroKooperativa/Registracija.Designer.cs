namespace AgroKooperativa
{
    partial class Registracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.errIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errKorisnickoIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(19, 116);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Location = new System.Drawing.Point(84, 165);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrujSe.TabIndex = 4;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = true;
            this.btnRegistrujSe.Click += new System.EventHandler(this.btnRegistrujSe_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(103, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(103, 62);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(103, 87);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnicko.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(103, 113);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 8;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(84, 194);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 9;
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
            // errKorisnickoIme
            // 
            this.errKorisnickoIme.ContainerControl = this;
            // 
            // errLozinka
            // 
            this.errLozinka.ContainerControl = this;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 229);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnRegistrujSe);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLozinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ErrorProvider errIme;
        private System.Windows.Forms.ErrorProvider errPrezime;
        private System.Windows.Forms.ErrorProvider errKorisnickoIme;
        private System.Windows.Forms.ErrorProvider errLozinka;
    }
}