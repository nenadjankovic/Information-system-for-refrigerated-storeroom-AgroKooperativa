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
            popuniOtkup();
            txtKolicinaIKlase.Enabled = false;
            txtKolicinaIIKlase.Enabled = false;
            txtKolicinaIKlase.Text = "0";
            txtKolicinaIIKlase.Text = "0";
            txtVraćeno.Text ="0";
            txtIzdato.Text = "0";
            
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

            if (cbProizvodjaci.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati proizvođača u pdajućoj listi!");
            }
            else if (cbVoce.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati voćeu padajućoj listi!");
            }
            else
            {


                Otkup o = new Otkup();

                decimal brutoI = decimal.Parse(txtKolicinaIKlase.Text);
                decimal brutoII = decimal.Parse(txtKolicinaIIKlase.Text);
                decimal tara = decimal.Parse(txtVraćeno.Text) * 0.4m;
                decimal netoI = 0;
                decimal netoII = 0;
                if (decimal.Parse(txtKolicinaIKlase.Text) == 0)
                {
                    netoI = 0;

                }
                else
                {
                    netoI = brutoI - tara;
                }
                if (decimal.Parse(txtKolicinaIIKlase.Text) == 0)
                {
                    netoII = 0;

                }
                else
                {
                    netoII = brutoII - tara;
                }



                o.BrutoKolicinaIKlase = brutoI;
                o.BrutoKolicinaIIKlase = brutoII;
                o.NetoKolicinaIKlase = netoI;
                o.NetoKolicinaIIKlase = netoII;
                o.Tara = tara;
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
                a.datum = dtpOtkup.Value;

                if (this.ambalazaBusiness.InsertAmbalaza(a))
                {

                }
                else
                {
                    MessageBox.Show("Neuspešno zavedena ambalaža");
                }

                popuniOtkup();
                txtKolicinaIKlase.Text = "0";
                txtKolicinaIIKlase.Text = "0";
                txtIzdato.Text = "0";
                txtVraćeno.Text = "0";
            }
        }
        

        private void btnStanjeOtkupa_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new PrikazStanjaOtkupa();
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

        

        private void rdI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdI.Checked)
            {
                txtKolicinaIKlase.Enabled = true;
            }
            else
            {
                txtKolicinaIKlase.Enabled = false;
            }
        }

        private void rbII_CheckedChanged(object sender, EventArgs e)
        {
            if (rbII.Checked)
            {
                txtKolicinaIIKlase.Enabled = true;
            }
            else
            {
                txtKolicinaIIKlase.Enabled = false;
            }
        }


        private void popuniOtkup()
        {
            dgwOtkup.DataSource = this.otkupBusiness.ucitajOtkup();
        }

        private void txtKolicinaIKlase_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void txtKolicinaIIKlase_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void txtVraćeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void txtIzdato_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDBrisanje.Text))
            {
                MessageBox.Show("Morate uneti ID otkupa za brisanje!");
            }
            else
            {
                int id = int.Parse(txtIDBrisanje.Text);
                if (this.otkupBusiness.DeleteOtkup(id))
                {
                    MessageBox.Show("Uspešno obrisan otkup!");
                }
                else
                {
                    MessageBox.Show("Neuspešno obrisan otkup!");
                }
                popuniOtkup();
            }
            
        }
    }
}
