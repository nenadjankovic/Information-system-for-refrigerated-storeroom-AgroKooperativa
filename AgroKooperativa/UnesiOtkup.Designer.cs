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
            this.cbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVoce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicinaIKlase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKoličinaIIKlase = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtkup)).BeginInit();
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
            this.txtKolicinaIKlase.Location = new System.Drawing.Point(26, 98);
            this.txtKolicinaIKlase.Name = "txtKolicinaIKlase";
            this.txtKolicinaIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaIKlase.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Količina I klase:";
            // 
            // txtKoličinaIIKlase
            // 
            this.txtKoličinaIIKlase.Location = new System.Drawing.Point(180, 98);
            this.txtKoličinaIIKlase.Name = "txtKoličinaIIKlase";
            this.txtKoličinaIIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtKoličinaIIKlase.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Količina II klase";
            // 
            // dtpOtkup
            // 
            this.dtpOtkup.Location = new System.Drawing.Point(77, 160);
            this.dtpOtkup.Name = "dtpOtkup";
            this.dtpOtkup.Size = new System.Drawing.Size(200, 20);
            this.dtpOtkup.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum otkupa:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(125, 277);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 46);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Unesi otkup";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVraćeno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIzdato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(26, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ambalaža";
            // 
            // txtVraćeno
            // 
            this.txtVraćeno.Location = new System.Drawing.Point(25, 41);
            this.txtVraćeno.Name = "txtVraćeno";
            this.txtVraćeno.Size = new System.Drawing.Size(100, 20);
            this.txtVraćeno.TabIndex = 3;
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
            this.txtIzdato.Size = new System.Drawing.Size(100, 20);
            this.txtIzdato.TabIndex = 1;
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
            this.btnNazad.Location = new System.Drawing.Point(26, 277);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 46);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnStanjeOtkupa
            // 
            this.btnStanjeOtkupa.Location = new System.Drawing.Point(226, 277);
            this.btnStanjeOtkupa.Name = "btnStanjeOtkupa";
            this.btnStanjeOtkupa.Size = new System.Drawing.Size(75, 46);
            this.btnStanjeOtkupa.TabIndex = 14;
            this.btnStanjeOtkupa.Text = "Stanje otkupa";
            this.btnStanjeOtkupa.UseVisualStyleBackColor = true;
            this.btnStanjeOtkupa.Click += new System.EventHandler(this.btnStanjeOtkupa_Click);
            // 
            // dgwOtkup
            // 
            this.dgwOtkup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOtkup.Location = new System.Drawing.Point(307, 30);
            this.dgwOtkup.Name = "dgwOtkup";
            this.dgwOtkup.Size = new System.Drawing.Size(288, 279);
            this.dgwOtkup.TabIndex = 15;
            // 
            // UnesiOtkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.dgwOtkup);
            this.Controls.Add(this.btnStanjeOtkupa);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpOtkup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKoličinaIIKlase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKolicinaIKlase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVoce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProizvodjaci);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnesiOtkup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otkup";
            this.Load += new System.EventHandler(this.UnesiOtkup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOtkup)).EndInit();
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
        private System.Windows.Forms.TextBox txtKoličinaIIKlase;
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
    }
}