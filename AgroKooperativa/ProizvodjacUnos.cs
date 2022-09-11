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

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Proizvodjac p = new Proizvodjac();

            p.ime = txtIme.Text;
            p.prezime = txtPrezime.Text;
            p.mesto = txtMesto.Text;
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
