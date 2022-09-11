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
            this.SuspendLayout();
            // 
            // cbProizvodjaci
            // 
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
            this.dtpOtkup.Location = new System.Drawing.Point(26, 161);
            this.dtpOtkup.Name = "dtpOtkup";
            this.dtpOtkup.Size = new System.Drawing.Size(200, 20);
            this.dtpOtkup.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum otkupa:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(51, 277);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 46);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Unesi otkup:";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // UnesiOtkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 335);
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
            this.Name = "UnesiOtkup";
            this.Text = "Otkup";
            this.Load += new System.EventHandler(this.UnesiOtkup_Load);
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
    }
}