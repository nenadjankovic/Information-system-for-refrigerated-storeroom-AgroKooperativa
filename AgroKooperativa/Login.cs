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

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string lozinka = txtLozinka.Text;

            List<Korisnik> korisnici = this.korisnikBusiness.GetAllKorisnici();


            foreach (Korisnik k in korisnici)
            {
                if (k.korisnickoIme == username && k.lozinka == lozinka)
                {
                    this.Hide();
                    var m = new Meni();
                    m.Closed += (s, args) => this.Close();
                    m.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Pogresna loznka ili username!");
                    txtUsername.Clear();
                    txtLozinka.Clear();
                    break;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
