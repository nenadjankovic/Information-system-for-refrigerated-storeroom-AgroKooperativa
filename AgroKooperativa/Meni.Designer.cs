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
            this.btnOdjavise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProizvodjaci
            // 
            this.btnProizvodjaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProizvodjaci.Image = ((System.Drawing.Image)(resources.GetObject("btnProizvodjaci.Image")));
            this.btnProizvodjaci.Location = new System.Drawing.Point(2, 3);
            this.btnProizvodjaci.Name = "btnProizvodjaci";
            this.btnProizvodjaci.Size = new System.Drawing.Size(150, 126);
            this.btnProizvodjaci.TabIndex = 0;
            this.btnProizvodjaci.Text = "Proizvođači";
            this.btnProizvodjaci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProizvodjaci.UseVisualStyleBackColor = true;
            this.btnProizvodjaci.Click += new System.EventHandler(this.btnProizvodjaci_Click);
            // 
            // btnCenaVoca
            // 
            this.btnCenaVoca.Image = ((System.Drawing.Image)(resources.GetObject("btnCenaVoca.Image")));
            this.btnCenaVoca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCenaVoca.Location = new System.Drawing.Point(158, 143);
            this.btnCenaVoca.Name = "btnCenaVoca";
            this.btnCenaVoca.Size = new System.Drawing.Size(150, 122);
            this.btnCenaVoca.TabIndex = 1;
            this.btnCenaVoca.Text = "Cena voća";
            this.btnCenaVoca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCenaVoca.UseVisualStyleBackColor = true;
            this.btnCenaVoca.Click += new System.EventHandler(this.btnCenaVoca_Click);
            // 
            // btnOtkup
            // 
            this.btnOtkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkup.Image = ((System.Drawing.Image)(resources.GetObject("btnOtkup.Image")));
            this.btnOtkup.Location = new System.Drawing.Point(158, 3);
            this.btnOtkup.Name = "btnOtkup";
            this.btnOtkup.Size = new System.Drawing.Size(150, 126);
            this.btnOtkup.TabIndex = 3;
            this.btnOtkup.Text = "Otkup";
            this.btnOtkup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtkup.UseVisualStyleBackColor = true;
            this.btnOtkup.Click += new System.EventHandler(this.btnOtkup_Click);
            // 
            // btnUkupnoStanje
            // 
            this.btnUkupnoStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkupnoStanje.Image = ((System.Drawing.Image)(resources.GetObject("btnUkupnoStanje.Image")));
            this.btnUkupnoStanje.Location = new System.Drawing.Point(2, 143);
            this.btnUkupnoStanje.Name = "btnUkupnoStanje";
            this.btnUkupnoStanje.Size = new System.Drawing.Size(150, 122);
            this.btnUkupnoStanje.TabIndex = 4;
            this.btnUkupnoStanje.Text = "Saldo";
            this.btnUkupnoStanje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUkupnoStanje.UseVisualStyleBackColor = true;
            this.btnUkupnoStanje.Click += new System.EventHandler(this.btnUkupnoStanje_Click);
            // 
            // btnAvans
            // 
            this.btnAvans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvans.Image = ((System.Drawing.Image)(resources.GetObject("btnAvans.Image")));
            this.btnAvans.Location = new System.Drawing.Point(314, 3);
            this.btnAvans.Name = "btnAvans";
            this.btnAvans.Size = new System.Drawing.Size(150, 126);
            this.btnAvans.TabIndex = 5;
            this.btnAvans.Text = "Avans";
            this.btnAvans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAvans.UseVisualStyleBackColor = true;
            this.btnAvans.Click += new System.EventHandler(this.btnAvans_Click);
            // 
            // btnOdjavise
            // 
            this.btnOdjavise.Image = ((System.Drawing.Image)(resources.GetObject("btnOdjavise.Image")));
            this.btnOdjavise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdjavise.Location = new System.Drawing.Point(314, 143);
            this.btnOdjavise.Name = "btnOdjavise";
            this.btnOdjavise.Size = new System.Drawing.Size(150, 122);
            this.btnOdjavise.TabIndex = 6;
            this.btnOdjavise.Text = "Odjavi se";
            this.btnOdjavise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdjavise.UseVisualStyleBackColor = true;
            this.btnOdjavise.Click += new System.EventHandler(this.btnOdjavise_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 271);
            this.Controls.Add(this.btnOdjavise);
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
        private System.Windows.Forms.Button btnOdjavise;
    }
}