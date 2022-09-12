using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroKooperativa
{
    public partial class CenaVoca : Form
    {
        private readonly CenaRepository cenaVocaRepository;
        private readonly CenaVocaBusiness cenaVocaBusiness;
        public CenaVoca()
        {
            this.cenaVocaRepository = new CenaRepository();
            this.cenaVocaBusiness = new CenaVocaBusiness();
            InitializeComponent();
        }

        private void CenaVoca_Load(object sender, EventArgs e)
        {
            ucitajCeneVoca();
        }

        private void ucitajCeneVoca()
        {
            
                dgwCenaVoca.AutoGenerateColumns = false;
                dgwCenaVoca.DataSource = this.cenaVocaBusiness.ucitajCeneVoca();
            
        }

        private void btnIzmeniCenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new IzmeniCenu();
            m.Closed += (s, args) => this.Close();
            m.Show();
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
