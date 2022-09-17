namespace AgroKooperativa
{
    partial class Meni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meni));
            this.btnProizvodjaci = new System.Windows.Forms.Button();
            this.btnCenaVoca = new System.Windows.Forms.Button();
            this.btnOtkup = new System.Windows.Forms.Button();
            this.btnUkupnoStanje = new System.Windows.Forms.Button();
            this.btnAvans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProizvodjaci
            // 
            this.btnProizvodjaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProizvodjaci.Image = ((System.Drawing.Image)(resources.GetObject("btnProizvodjaci.Image")));
            this.btnProizvodjaci.Location = new System.Drawing.Point(2, 3);
            this.btnProizvodjaci.Name = "btnProizvodjaci";
            this.btnProizvodjaci.Size = new System.Drawing.Size(150, 113);
            this.btnProizvodjaci.TabIndex = 0;
            this.btnProizvodjaci.Text = "Proizvođači";
            this.btnProizvodjaci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProizvodjaci.UseVisualStyleBackColor = true;
            this.btnProizvodjaci.Click += new System.EventHandler(this.btnProizvodjaci_Click);
            // 
            // btnCenaVoca
            // 
            this.btnCenaVoca.Location = new System.Drawing.Point(314, 152);
            this.btnCenaVoca.Name = "btnCenaVoca";
            this.btnCenaVoca.Size = new System.Drawing.Size(150, 113);
            this.btnCenaVoca.TabIndex = 1;
            this.btnCenaVoca.Text = "Cena voća";
            this.btnCenaVoca.UseVisualStyleBackColor = true;
            this.btnCenaVoca.Click += new System.EventHandler(this.btnCenaVoca_Click);
            // 
            // btnOtkup
            // 
            this.btnOtkup.Location = new System.Drawing.Point(158, 79);
            this.btnOtkup.Name = "btnOtkup";
            this.btnOtkup.Size = new System.Drawing.Size(150, 113);
            this.btnOtkup.TabIndex = 3;
            this.btnOtkup.Text = "Otkup";
            this.btnOtkup.UseVisualStyleBackColor = true;
            this.btnOtkup.Click += new System.EventHandler(this.btnOtkup_Click);
            // 
            // btnUkupnoStanje
            // 
            this.btnUkupnoStanje.Location = new System.Drawing.Point(2, 152);
            this.btnUkupnoStanje.Name = "btnUkupnoStanje";
            this.btnUkupnoStanje.Size = new System.Drawing.Size(150, 113);
            this.btnUkupnoStanje.TabIndex = 4;
            this.btnUkupnoStanje.Text = "Saldo";
            this.btnUkupnoStanje.UseVisualStyleBackColor = true;
            this.btnUkupnoStanje.Click += new System.EventHandler(this.btnUkupnoStanje_Click);
            // 
            // btnAvans
            // 
            this.btnAvans.Location = new System.Drawing.Point(314, 3);
            this.btnAvans.Name = "btnAvans";
            this.btnAvans.Size = new System.Drawing.Size(150, 113);
            this.btnAvans.TabIndex = 5;
            this.btnAvans.Text = "Avans";
            this.btnAvans.UseVisualStyleBackColor = true;
            this.btnAvans.Click += new System.EventHandler(this.btnAvans_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 271);
            this.Controls.Add(this.btnAvans);
            this.Controls.Add(this.btnUkupnoStanje);
            this.Controls.Add(this.btnOtkup);
            this.Controls.Add(this.btnCenaVoca);
            this.Controls.Add(this.btnProizvodjaci);
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meni";
            this.Load += new System.EventHandler(this.Meni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProizvodjaci;
        private System.Windows.Forms.Button btnCenaVoca;
        private System.Windows.Forms.Button btnOtkup;
        private System.Windows.Forms.Button btnUkupnoStanje;
        private System.Windows.Forms.Button btnAvans;
    }
}