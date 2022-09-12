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
        private readonly CenaVocaBusiness cenaVocaBusiness;
        private readonly AmbalazaBusiness ambalazaBusiness;

        public PrikazStanjaOtkupa()
        {
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.voceBusiness = new VoceBusiness();
            this.otkupBusiness = new OtkupBusiness();
            this.cenaVocaBusiness = new CenaVocaBusiness();
            this.ambalazaBusiness = new AmbalazaBusiness();
            
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
            List<Cena> cene = this.cenaVocaBusiness.GetAllCena();

            lblVoce.Text = nazivVoca;
            decimal sumaI = 0;
            decimal sumaII = 0;
            foreach(Otkup o in otkup)
            {
                if (o.idProizvodjaca == idProizvodjaca && o.IDVoca == idVoca)
                {
                    sumaI += o.KolicinaIKlase;
                    sumaII += o.KolicinaIIKlase;
                }
                
            }
          

            lblKolicinaIKlase.Text =  Convert.ToString(sumaI);
            lblKolicinaIIklase.Text = Convert.ToString(sumaII);
            foreach(Cena c in cene)
            {
                if (c.FK_IDVoca == idVoca)
                {
                    lblCenaIKlase.Text = Convert.ToString(c.CenaIKlase);
                    lblCena2Klase.Text = Convert.ToString(c.CenaIIKlase);
                    decimal uk = (sumaI * c.CenaIKlase) + (sumaII * c.CenaIIKlase);
                    lblUkupno.Text = Convert.ToString(Math.Round(uk, 2));
                } 
            }
            
            


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
                cbPrAmbalaza.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);

            }

         }

        private void btnUcitajAmbalazu_Click(object sender, EventArgs e)
        {
            string prAm = cbPrAmbalaza.GetItemText(cbPrAmbalaza.SelectedItem); //ceo combo
            string idPrAm = prAm.Substring(0, prAm.IndexOf(" ")); //odvajanje samo id
            int idProizvodjacaAm = Convert.ToInt32(idPrAm);
            List<Ambalaza> ambalaze = this.ambalazaBusiness.GetAllAmbalaza();
            int sumaIz = 0;
            int sumaVr = 0;
            foreach(Ambalaza a in ambalaze)
            {
                if(a.idProizvodjaca == idProizvodjacaAm)
                {
                    sumaIz = sumaIz + a.izdato;
                    sumaVr += a.vraceno;
                }
            }
            lblIzdato.Text = Convert.ToString(sumaIz);
            lblVraceno.Text = Convert.ToString(sumaVr);
            lblStanje.Text = Convert.ToString(sumaIz - sumaVr);
        }
    }
}
