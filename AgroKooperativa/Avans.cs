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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                cbPRpojedinacno.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbProiz.SelectedIndex == -1) //znaci da nije izabrano nista
            {
                MessageBox.Show("Odaberite proizvođača u padajućoj listi!");
            }

            else if (string.IsNullOrEmpty(txtSuma.Text))
            {
                MessageBox.Show("Morate uneti sumu avansa!");
            }
            else
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

        public Proizvodjac odrediProizvodjacaPojedinacno()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            Proizvodjac result = new Proizvodjac();
            string IDImePrezimeProizvodjaca = cbPRpojedinacno.GetItemText(cbPRpojedinacno.SelectedItem);
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
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Morate uneti ID avansa koji podleže izmenama!");
            }
            else if (cbPrIzmeni.SelectedIndex == -1) //znaci da nije izabrano nista
            {
                MessageBox.Show("Odaberite proizvođača u padajućoj listi!");
            } 
            else if (string.IsNullOrEmpty(txtSumaIzmeni.Text))
            {
                MessageBox.Show("Morate uneti sumu avansa!");
            }
            else
            {
                Avansi avans = new Avansi();
                avans.idAvans = int.Parse(txtID.Text);
                avans.Datum = dtpIzmeni.Value;
                avans.Suma = decimal.Parse(txtSumaIzmeni.Text);
                avans.idProizvodjaca = odrediProizvodjacaUpdate().idProizvodjaca;
                if (this.avansBusiness.UpdateAvans(avans))
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
            }
            dgwAvans.DataSource = this.avansBusiness.ucitajAvans();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDObrisi.Text))
            {
                MessageBox.Show("Morate uneti ID avansa koji se briše!");
            }
            else
            {
                if (this.avansBusiness.DeleteAvans(int.Parse(txtIDObrisi.Text)))
                {
                    MessageBox.Show("Uspešno!");
                    txtIDObrisi.Clear();
                }
                else
                {
                    MessageBox.Show("Neupešno!");
                }
                dgwAvans.DataSource = this.avansBusiness.ucitajAvans();
            }
        }

        private void btnUcitajUk_Click(object sender, EventArgs e)
        {
            if (cbPRpojedinacno.SelectedIndex == -1) //znaci da nije izabrano nista
            {
                MessageBox.Show("Odaberite proizvođača u padajućoj listi!");
            }
            else
            {
                List<Avansi> avansi = this.avansBusiness.GetAllAvans();
                decimal suma = 0;

                foreach (Avansi a in avansi)
                {
                    if (a.idProizvodjaca == odrediProizvodjacaPojedinacno().idProizvodjaca)
                    {
                        suma += a.Suma;
                    }
                }
                lblUkAvansa.Text = Convert.ToString(suma);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
