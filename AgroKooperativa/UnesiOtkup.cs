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
    public partial class UnesiOtkup : Form
    {
        private readonly ProizvodjacBusiness proizvodjacBusiness;
        private readonly VoceBusiness voceBusiness;
        private readonly OtkupBusiness otkupBusiness;
        private readonly AmbalazaBusiness ambalazaBusiness;
        public UnesiOtkup()
        {
            InitializeComponent();
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.voceBusiness = new VoceBusiness();
            this.otkupBusiness = new OtkupBusiness();   
            this.ambalazaBusiness = new AmbalazaBusiness();
        }

        private void UnesiOtkup_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }
        public void fillComboBox()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            foreach (Proizvodjac p in proizvodjaci)
            {
                cbProizvodjaci.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }

            List<Voce> voce = this.voceBusiness.GetAllVoce();

            foreach(Voce v in voce)
            {
                cbVoce.Items.Add(v.Naziv);
            }
        }

        public Voce odrediVoce()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();
            Voce result = new Voce();
            string nazivVoca = cbVoce.GetItemText(cbVoce.SelectedItem);
            foreach(Voce v in voce)
            {
                if(v.Naziv == nazivVoca)
                {
                    result = v;
                }
            }
            return result;
            
        }
        public Proizvodjac odrediProizvodjaca()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            Proizvodjac result = new Proizvodjac();
            string IDImePrezimeProizvodjaca = cbProizvodjaci.GetItemText(cbProizvodjaci.SelectedItem);
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

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Otkup o = new Otkup();

            o.KolicinaIKlase = Convert.ToDecimal(txtKolicinaIKlase.Text);
            txtKoličinaIIKlase.Text = "0";
            o.KolicinaIIKlase = Convert.ToDecimal(txtKoličinaIIKlase.Text);
            o.Datum = dtpOtkup.Value;
            o.IDVoca = odrediVoce().IDVoca;
            o.idProizvodjaca = odrediProizvodjaca().idProizvodjaca;

            if (this.otkupBusiness.InsertOtkup(o))
            {
                MessageBox.Show("Uspešno unet otkup!");
            }
            else
            {
                MessageBox.Show("Neuspešno zaveden otkup!");
            }

            Ambalaza a = new Ambalaza();
            a.vraceno = Convert.ToInt32(txtVraćeno.Text);
            a.izdato = Convert.ToInt32(txtIzdato.Text);
            a.idProizvodjaca = odrediProizvodjaca().idProizvodjaca;

            if (this.ambalazaBusiness.InsertAmbalaza(a))
            {

            }
            else
            {
                MessageBox.Show("Neuspešno zavedena ambalaža");
            }
        }
    }
}
