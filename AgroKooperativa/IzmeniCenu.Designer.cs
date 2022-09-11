namespace AgroKooperativa
{
    partial class IzmeniCenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnIzmeniCenu = new System.Windows.Forms.Button();
            this.txtCenaIIKlase = new System.Windows.Forms.TextBox();
            this.txtCenaIKlase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDvoca = new System.Windows.Forms.TextBox();
            this.dgwVoce = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoce)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNazad);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.btnIzmeniCenu);
            this.groupBox1.Controls.Add(this.txtCenaIIKlase);
            this.groupBox1.Controls.Add(this.txtCenaIKlase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDvoca);
            this.groupBox1.Location = new System.Drawing.Point(39, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena cene";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(60, 69);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 9;
            // 
            // btnIzmeniCenu
            // 
            this.btnIzmeniCenu.Location = new System.Drawing.Point(60, 111);
            this.btnIzmeniCenu.Name = "btnIzmeniCenu";
            this.btnIzmeniCenu.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeniCenu.TabIndex = 8;
            this.btnIzmeniCenu.Text = "Izmeni cenu";
            this.btnIzmeniCenu.UseVisualStyleBackColor = true;
            this.btnIzmeniCenu.Click += new System.EventHandler(this.btnIzmeniCenu_Click);
            // 
            // txtCenaIIKlase
            // 
            this.txtCenaIIKlase.Location = new System.Drawing.Point(227, 43);
            this.txtCenaIIKlase.Name = "txtCenaIIKlase";
            this.txtCenaIIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtCenaIIKlase.TabIndex = 7;
            // 
            // txtCenaIKlase
            // 
            this.txtCenaIKlase.Location = new System.Drawing.Point(110, 43);
            this.txtCenaIKlase.Name = "txtCenaIKlase";
            this.txtCenaIKlase.Size = new System.Drawing.Size(100, 20);
            this.txtCenaIKlase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena II klase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID voća:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena I klase:";
            // 
            // txtIDvoca
            // 
            this.txtIDvoca.Location = new System.Drawing.Point(6, 43);
            this.txtIDvoca.Name = "txtIDvoca";
            this.txtIDvoca.Size = new System.Drawing.Size(75, 20);
            this.txtIDvoca.TabIndex = 3;
            // 
            // dgwVoce
            // 
            this.dgwVoce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVoce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVoce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv});
            this.dgwVoce.Location = new System.Drawing.Point(39, 8);
            this.dgwVoce.Name = "dgwVoce";
            this.dgwVoce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwVoce.Size = new System.Drawing.Size(333, 172);
            this.dgwVoce.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDVoca";
            this.ID.HeaderText = "ID voća";
            this.ID.Name = "ID";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv voća";
            this.Naziv.Name = "Naziv";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(185, 111);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 10;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // IzmeniCenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwVoce);
            this.Name = "IzmeniCenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena cene voća";
            this.Load += new System.EventHandler(this.IzmeniCenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVoce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnIzmeniCenu;
        private System.Windows.Forms.TextBox txtCenaIIKlase;
        private System.Windows.Forms.TextBox txtCenaIKlase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDvoca;
        private System.Windows.Forms.DataGridView dgwVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnNazad;
    }
}