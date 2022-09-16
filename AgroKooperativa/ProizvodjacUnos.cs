using BusinessLayer;
using DataLayer;
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
    public partial class ProizvodjacUnos : Form
    {
        private readonly ProizvodjacRepository proizvodjacRepository;
        private readonly ProizvodjacBusiness proizvodjacBusiness;

        public ProizvodjacUnos()
        {
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.proizvodjacRepository = new ProizvodjacRepository();
            InitializeComponent();
        }

        private void ProizvodjacUnos_Load(object sender, EventArgs e)
        {
            txtMesto.Text = null;
             
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            //validacija ime

            if (string.IsNullOrEmpty(txtIme.Text.Trim()))
            {
                errIme.SetError(txtIme, "Polje ime je obavezno!");
                return;
            }
            else
            {
                errIme.SetError(txtIme, string.Empty);
            }

            //validacija prezime

            if (string.IsNullOrEmpty(txtPrezime.Text.Trim()))
            {
                errPrezime.SetError(txtPrezime, "Polje prezime je obavezno!");
                return;
            }
            else
            {
                errPrezime.SetError(txtPrezime, string.Empty);
            }

            

            if (string.IsNullOrEmpty(txtTelefon.Text.Trim()))
            {
                errTelefon.SetError(txtTelefon, "Polje telefon je obavezno!");
                return;
            }
            else
            {
                errTelefon.SetError(txtTelefon, string.Empty);
            }

            if (string.IsNullOrEmpty(txtBPG.Text.Trim()))
            {
                errBPG.SetError(txtBPG, "Polje BPG je obavezno!");
                return;
            }
            else
            {
                errBPG.SetError(txtBPG, string.Empty);
            }

            Proizvodjac p = new Proizvodjac();

            p.ime = txtIme.Text;
            p.prezime = txtPrezime.Text;
            if (string.IsNullOrEmpty(txtMesto.Text))
            {
                p.mesto = " ";
            }
            else
            {
                p.mesto = txtMesto.Text;
            }            
            p.telefon = txtTelefon.Text;
            p.BPG = Convert.ToInt64(txtBPG.Text);

            if (this.proizvodjacBusiness.InsertProzvodjac(p))
            {
                MessageBox.Show("Uspešno dodat proizvođač!");
                txtIme.Clear();
                txtPrezime.Clear();
                txtMesto.Clear();
                txtTelefon.Clear();
                txtBPG.Clear();
            }
            else
            {
                MessageBox.Show("Neuspešno dodat proizvođač!");
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Proizvodjaci();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
