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
            this.dgwCenaVoca = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaIIKlase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzmeniCenu = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).BeginInit();
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
            // btnIzmeniCenu
            // 
            this.btnIzmeniCenu.Location = new System.Drawing.Point(71, 286);
            this.btnIzmeniCenu.Name = "btnIzmeniCenu";
            this.btnIzmeniCenu.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeniCenu.TabIndex = 1;
            this.btnIzmeniCenu.Text = "Izmeni cenu";
            this.btnIzmeniCenu.UseVisualStyleBackColor = true;
            this.btnIzmeniCenu.Click += new System.EventHandler(this.btnIzmeniCenu_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(216, 286);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // CenaVoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 313);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzmeniCenu);
            this.Controls.Add(this.dgwCenaVoca);
            this.Name = "CenaVoca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CenaVoca";
            this.Load += new System.EventHandler(this.CenaVoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCenaVoca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCenaVoca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaIIKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Button btnIzmeniCenu;
        private System.Windows.Forms.Button btnNazad;
    }
}