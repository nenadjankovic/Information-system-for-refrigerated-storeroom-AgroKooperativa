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
            this.dgwAvans = new System.Windows.Forms.DataGridView();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.cbProiz = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpAvans = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIzmeni = new System.Windows.Forms.DateTimePicker();
            this.cbPrIzmeni = new System.Windows.Forms.ComboBox();
            this.txtSumaIzmeni = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.idavans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgwAvans.Location = new System.Drawing.Point(12, 22);
            this.dgwAvans.Name = "dgwAvans";
            this.dgwAvans.Size = new System.Drawing.Size(427, 362);
            this.dgwAvans.TabIndex = 0;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(47, 105);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(121, 20);
            this.txtSuma.TabIndex = 1;
            // 
            // cbProiz
            // 
            this.cbProiz.FormattingEnabled = true;
            this.cbProiz.Location = new System.Drawing.Point(47, 30);
            this.cbProiz.Name = "cbProiz";
            this.cbProiz.Size = new System.Drawing.Size(121, 21);
            this.cbProiz.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(47, 131);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 28);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj avans";
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpAvans);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cbProiz);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Location = new System.Drawing.Point(445, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj avans";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpIzmeni);
            this.groupBox2.Controls.Add(this.cbPrIzmeni);
            this.groupBox2.Controls.Add(this.txtSumaIzmeni);
            this.groupBox2.Location = new System.Drawing.Point(445, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmeni avans";
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
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(47, 166);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(121, 28);
            this.btnIzmeni.TabIndex = 7;
            this.btnIzmeni.Text = "Izmeni avans";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
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
            // Avans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwAvans);
            this.Name = "Avans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avans";
            this.Load += new System.EventHandler(this.Avans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAvans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAvans;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.ComboBox cbProiz;
        private System.Windows.Forms.Button btnDodaj;
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
    }
}