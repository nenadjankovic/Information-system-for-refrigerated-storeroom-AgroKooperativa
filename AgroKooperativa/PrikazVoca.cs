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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AgroKooperativa
{
    public partial class PrikazVoca : Form
    {
        private readonly VoceBusiness voceBusiness;
        public PrikazVoca()
        {
            InitializeComponent();
            this.voceBusiness = new VoceBusiness();
        }

        private void PrikazVoca_Load(object sender, EventArgs e)
        {
            dgwVoce.DataSource = this.voceBusiness.ucitajVoce();
            fillCombo();
            
        }

        private void fillCombo()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();
            foreach(Voce v in voce)
            {
                cbVoce.Items.Add(v.IDVoca + " " + v.Naziv);
            }
        }

        private Voce odrediVoce()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();
            Voce result = new Voce();
            string IDiNAziv = cbVoce.GetItemText(cbVoce.SelectedItem);
            string idVoca = IDiNAziv.Substring(0, IDiNAziv.IndexOf(" "));
            int id = int.Parse(idVoca);
            foreach(Voce v in voce)
            {
                if(v.IDVoca == id)
                {
                    result = v;
                }
            }
            return result;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(cbVoce.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite voće iz padajuće liste");
            }
            else
            {
                int id = odrediVoce().IDVoca;
                if (this.voceBusiness.DeleteVoce(id))
                {
                    MessageBox.Show("Uspešno obrisano voće!");
                }
                else
                {
                    MessageBox.Show("Neuspešno obrisano voće!");
                }

                dgwVoce.DataSource = this.voceBusiness.ucitajVoce();
                fillCombo();
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                errNaziv.SetError(txtNaziv, "Polje naziv je obavezno!");
                return;
            }
            else
            {
                errNaziv.SetError(txtNaziv, string.Empty);
            }
            Voce v = new Voce();
            string naziv = txtNaziv.Text;

            v.Naziv = naziv;

            if (this.voceBusiness.InsertVoce(v))
            {
                MessageBox.Show("Uspešno dodato voće!");
            }
            else
            {
                MessageBox.Show("Neupešno dodato voće!");
            }
               
           

            dgwVoce.DataSource = this.voceBusiness.ucitajVoce();
            fillCombo();

        }

        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
