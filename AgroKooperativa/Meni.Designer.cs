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
            this.btnProizvodjaci = new System.Windows.Forms.Button();
            this.btnCenaVoca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProizvodjaci
            // 
            this.btnProizvodjaci.Location = new System.Drawing.Point(93, 99);
            this.btnProizvodjaci.Name = "btnProizvodjaci";
            this.btnProizvodjaci.Size = new System.Drawing.Size(75, 50);
            this.btnProizvodjaci.TabIndex = 0;
            this.btnProizvodjaci.Text = "Proizvođači";
            this.btnProizvodjaci.UseVisualStyleBackColor = true;
            this.btnProizvodjaci.Click += new System.EventHandler(this.btnProizvodjaci_Click);
            // 
            // btnCenaVoca
            // 
            this.btnCenaVoca.Location = new System.Drawing.Point(192, 99);
            this.btnCenaVoca.Name = "btnCenaVoca";
            this.btnCenaVoca.Size = new System.Drawing.Size(75, 50);
            this.btnCenaVoca.TabIndex = 1;
            this.btnCenaVoca.Text = "Cena voća";
            this.btnCenaVoca.UseVisualStyleBackColor = true;
            this.btnCenaVoca.Click += new System.EventHandler(this.btnCenaVoca_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCenaVoca);
            this.Controls.Add(this.btnProizvodjaci);
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProizvodjaci;
        private System.Windows.Forms.Button btnCenaVoca;
    }
}