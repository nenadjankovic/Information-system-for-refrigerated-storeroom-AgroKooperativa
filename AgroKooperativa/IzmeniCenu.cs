using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroKooperativa
{
    public partial class IzmeniCenu : Form
    {
        private readonly CenaVocaBusiness cenaVocaBusiness;
        private readonly VoceBusiness voceBusiness;
        public IzmeniCenu()
        {
            InitializeComponent();
            this.cenaVocaBusiness = new CenaVocaBusiness();
            this.voceBusiness = new VoceBusiness();
        }

        private void IzmeniCenu_Load(object sender, EventArgs e)
        {

            dgwVoce.DataSource = this.voceBusiness.ucitajVoce();

        }

        private void btnIzmeniCenu_Click(object sender, EventArgs e)
        {
            Cena c = new Cena();
            c.FK_IDVoca = Convert.ToInt32(txtIDvoca.Text);
            c.CenaIKlase = Convert.ToDecimal(txtCenaIKlase.Text);
            c.CenaIIKlase = Convert.ToDecimal(txtCenaIIKlase.Text);
            c.Datum = dtpDatum.Value;
            if (this.cenaVocaBusiness.UpdateCenuVoca(c))
            {     
                MessageBox.Show("Uspesno azurirana cena");
                txtCenaIKlase.Clear();
                txtCenaIIKlase.Clear();
                txtIDvoca.Clear();
            }
            else
                MessageBox.Show("Neuspesno azurirana cena");
            

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new CenaVoca();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
