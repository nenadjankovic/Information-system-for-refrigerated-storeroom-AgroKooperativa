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
    public partial class Registracija : Form
    {
        private readonly KorisnikBusiness korisnikBusiness;
        public Registracija()
        {
            InitializeComponent();
            this.korisnikBusiness = new KorisnikBusiness();
        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
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
            //validacija korisnicko ime
            if (string.IsNullOrEmpty(txtKorisnicko.Text.Trim()))
            {
                errKorisnickoIme.SetError(txtKorisnicko, "Korisničko ime je obavezno polje!");
                return;
            }
            else
            {
                errKorisnickoIme.SetError(txtKorisnicko, string.Empty);
            }
            // validacija lozinka
            if (string.IsNullOrEmpty(lblLozinka.Text.Trim()))
            {
                errLozinka.SetError(lblLozinka, "Morate uneti lozinku!");
                return;
            }
            else
            {
                errLozinka.SetError(lblLozinka, string.Empty);
            }
            if (this.korisnikBusiness.ProveraPonavljanjaKorisnickogImena(txtKorisnicko.Text.Trim()).Rows.Count > 0)
            {
                MessageBox.Show("Korisnik sa ovim korisničkim imenom već postoji!");
            }
            else
            {
                
                Korisnik k = new Korisnik();
                k.ime = txtIme.Text.Trim();
                k.prezime = txtPrezime.Text.Trim();
                k.korisnickoIme = txtKorisnicko.Text.Trim();
                k.lozinka = txtLozinka.Text.Trim();

                if (txtLozinka.Text.Length < 8)
                {
                    MessageBox.Show("Lozinka mora imati najmanje 8 karaktera!");
                }
                else
                {
                    if (this.korisnikBusiness.InsertKorisnik(k))
                    {
                        MessageBox.Show("Uspešno registrovan korisnik!");
                        txtIme.Clear();
                        txtPrezime.Clear();
                        txtKorisnicko.Clear();
                        txtLozinka.Clear();
                    }
                }

            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Login();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
