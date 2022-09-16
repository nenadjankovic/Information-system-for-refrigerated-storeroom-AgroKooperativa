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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgroKooperativa
{
    public partial class Login : Form
    {
        private readonly KorisnikRepository korisnikRepository;
        private readonly KorisnikBusiness korisnikBusiness;
        public Login()
        {
            this.korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "Korisničko ime je obavezno polje!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
            if (string.IsNullOrEmpty(txtLozinka.Text.Trim()))
            {
                errorProvider2.SetError(txtLozinka, "Morate uneti lozinku!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtLozinka, string.Empty);
            }


            string username = txtUsername.Text;
            string lozinka = txtLozinka.Text;

          

            if(this.korisnikBusiness.loginData(username,lozinka).Rows.Count == 1)
            {
                this.Hide();
                var m = new Meni();
                m.Closed += (s, args) => this.Close();
                m.Show();

                txtUsername.Clear();
                txtLozinka.Clear();
                
            }
            else
            {
                MessageBox.Show("Pogrešno uneti podaci za prijavu!");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrujse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Registracija();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        
    }
}
