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
    public partial class Avans : Form
    {
        private readonly AvansBusiness avansBusiness;
        private readonly ProizvodjacBusiness proizvodjacBusiness;
        public Avans()
        {
            InitializeComponent();
            this.avansBusiness = new AvansBusiness();
            this.proizvodjacBusiness = new ProizvodjacBusiness();
        }

        private void Avans_Load(object sender, EventArgs e)
        {
            dgwAvans.DataSource = this.avansBusiness.ucitajAvans();
            fillCombo();
        }

        public void fillCombo()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            foreach(Proizvodjac p in proizvodjaci)
            {
                cbProiz.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
                cbPrIzmeni.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Avansi a = new Avansi();
            a.Datum = dtpAvans.Value;
            a.Suma = Convert.ToDecimal(txtSuma.Text);
            a.idProizvodjaca = odrediProizvodjacaInsert().idProizvodjaca;

            if (this.avansBusiness.InsertAvans(a))
            {
                MessageBox.Show("Uspešno unet avans!");
                txtSuma.Clear();
                cbProiz.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Neuspešno unet avans!");
            }

            dgwAvans.DataSource = this.avansBusiness.ucitajAvans();



        }

        public Proizvodjac odrediProizvodjacaInsert()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            Proizvodjac result = new Proizvodjac();
            string IDImePrezimeProizvodjaca = cbProiz.GetItemText(cbProiz.SelectedItem);
            string IDProizvodjacaSTR = IDImePrezimeProizvodjaca.Substring(0, IDImePrezimeProizvodjaca.IndexOf(" "));
            int idPr = Convert.ToInt32(IDProizvodjacaSTR);
            foreach (Proizvodjac p in proizvodjaci)
            {
                if (p.idProizvodjaca == idPr)
                {
                    result = p;
                }
            }
            return result;

        }
        public Proizvodjac odrediProizvodjacaUpdate()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            Proizvodjac result = new Proizvodjac();
            string IDImePrezimeProizvodjaca = cbPrIzmeni.GetItemText(cbPrIzmeni.SelectedItem);
            string IDProizvodjacaSTR = IDImePrezimeProizvodjaca.Substring(0, IDImePrezimeProizvodjaca.IndexOf(" "));
            int idPr = Convert.ToInt32(IDProizvodjacaSTR);
            foreach (Proizvodjac p in proizvodjaci)
            {
                if (p.idProizvodjaca == idPr)
                {
                    result = p;
                }
            }
            return result;

        }



        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Avansi a = new Avansi();
            a.idAvans = int.Parse(txtID.Text);
            a.Datum = dtpIzmeni.Value;
            a.Suma = decimal.Parse(txtSumaIzmeni.Text);
            a.idProizvodjaca = odrediProizvodjacaUpdate().idProizvodjaca;
            if (this.avansBusiness.UpdateAvans(a))
            {
                MessageBox.Show("Uspešno!");
                txtSumaIzmeni.Clear();
                cbPrIzmeni.Text = String.Empty;
                txtID.Clear();
            }
            else
            {
                MessageBox.Show("Neuspešno!");
            }

            dgwAvans.DataSource = this.avansBusiness.ucitajAvans();
        }
    }
}
