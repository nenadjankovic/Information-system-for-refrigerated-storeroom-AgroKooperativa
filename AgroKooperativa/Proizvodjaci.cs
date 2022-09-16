using BusinessLayer;
using DataLayer;
using DataLayer.Models;
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
            fillCombo();
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
            try
            {

                if(cbPr.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate selektovati proizvođača u padajućoj listi!");
                }
                else
                {
                    if (this.proizvodjacBusiness.DeleteProizovdjac(odrediProizvodjaca().idProizvodjaca))
                    {
                        MessageBox.Show("Uspešno obrisan proizvođač!");
                    }
                   
                }
                ucitajProizvodjace();
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mozete obrisati ovog proizvođača!");
            }
           
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void txtIDzaBrisanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void gbObrisi_Enter(object sender, EventArgs e)
        {

        }

        public void fillCombo()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            foreach (Proizvodjac p in proizvodjaci)
            {
                cbPr.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }
        }
        public Proizvodjac odrediProizvodjaca()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            Proizvodjac result = new Proizvodjac();
            string IDImePrezimeProizvodjaca = cbPr.GetItemText(cbPr.SelectedItem);
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
    }
}
