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
    public partial class Proizvodjaci : Form
    {
        private readonly ProizvodjacRepository proizvodjaciRepository;
        private readonly ProizvodjacBusiness proizvodjacBusiness;
        public Proizvodjaci()
        {
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.proizvodjaciRepository = new ProizvodjacRepository();
            InitializeComponent();
        }

        private void Proizvodjaci_Load(object sender, EventArgs e)
        {
            ucitajProizvodjace();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
           

        }
        
      /*  private void ucitajProizvodjace()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Proizvodjaci", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgwProizvodjaci.AutoGenerateColumns = false;
                dgwProizvodjaci.DataSource = dtbl;
            }
        }*/
        private void ucitajProizvodjace()
        {
            dgwProizvodjaci.DataSource = this.proizvodjacBusiness.ucitajProizvodjace();
            dgwProizvodjaci.AutoGenerateColumns = false;
            dgwProizvodjaci.Sort(dgwProizvodjaci.Columns[0], ListSortDirection.Ascending);
        }

        private void btnDodajProizvodjaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new ProizvodjacUnos();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDzaBrisanje.Text);
            if (proizvodjacBusiness.DeleteProizovdjac(id)) { 
                MessageBox.Show("Uspešno obrisan izlaz!");
                ucitajProizvodjace();
            }
            else
            {
                MessageBox.Show("Pogrešan ID!");
                txtIDzaBrisanje.Clear();
                ucitajProizvodjace();
            }
            txtIDzaBrisanje.Clear();
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
