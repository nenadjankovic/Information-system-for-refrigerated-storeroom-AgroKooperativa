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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroKooperativa
{
    public partial class PrikazStanjaOtkupa : Form
    {
        private readonly VoceBusiness voceBusiness;
        private readonly ProizvodjacBusiness proizvodjacBusiness;
        private readonly OtkupBusiness otkupBusiness;
        public PrikazStanjaOtkupa()
        {
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.voceBusiness = new VoceBusiness();
            this.otkupBusiness = new OtkupBusiness();
            
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string pr = cbProizvodjac.GetItemText(cbProizvodjac.SelectedItem); //ceo combo
            string idPr = pr.Substring(0, pr.IndexOf(" ")); //odvajanje samo id
            int idProizvodjaca = Convert.ToInt32(idPr);

            string vocestr = cbVoce.GetItemText(cbVoce.SelectedItem);
            string idVocaStr = vocestr.Substring(0, vocestr.IndexOf(" "));
            string nazivVoca = vocestr.Substring(vocestr.IndexOf(" "), vocestr.Length-1);
            int idVoca = Convert.ToInt32(idVocaStr);

            List<Voce> voce  = this.voceBusiness.GetAllVoce();
            List < Proizvodjac > proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            List<Otkup> otkup = this.otkupBusiness.GetAllOtkup();

            lblVoce.Text = nazivVoca;
            decimal suma = 0;
            foreach(Otkup o in otkup)
            {
                if (o.idProizvodjaca == idProizvodjaca)
                {
                    suma += o.KolicinaIKlase;
                }
                else
                    suma = 0;
            }

            lblKolicina.Text =  Convert.ToString(suma);

            


        }

        private void PrikazStanjaOtkupa_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        public void fillCombo()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();
            foreach (Voce v in voce)
            {
                cbVoce.Items.Add(v.IDVoca + " " + v.Naziv);
            }

            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            foreach (Proizvodjac p in proizvodjaci)
            {
                cbProizvodjac.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }

         }

       /* public void FillGrid(int idVoca, int idProizvodjaca)
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select Voce.Naziv, Otkup.KolicinaIKlase from Voce,Otkup where Voce.IDVoca = " + idVoca + "AND Otkup.idProizvodjaca = " + idProizvodjaca, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgwStanje.DataSource = dtbl;
            }
        }*/
    }
}
