﻿using BusinessLayer;
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
    public partial class CenaVoca : Form
    {
        private readonly CenaRepository cenaVocaRepository;
        private readonly CenaVocaBusiness cenaVocaBusiness;
        private readonly VoceBusiness voceBusiness;
        public CenaVoca()
        {
            this.cenaVocaRepository = new CenaRepository();
            this.cenaVocaBusiness = new CenaVocaBusiness();
            this.voceBusiness = new VoceBusiness();
            InitializeComponent();
        }

        private void CenaVoca_Load(object sender, EventArgs e)
        {
            ucitajCeneVoca();
            fillCombo();
        }

        private void ucitajCeneVoca()
        {

            dgwCenaVoca.AutoGenerateColumns = false;
            dgwCenaVoca.DataSource = this.cenaVocaBusiness.ucitajCeneVoca();

        }
        public void fillCombo()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();

            foreach (Voce v in voce)
            {
                cbVoce.Items.Add(v.Naziv);
            }
        }

        private void btnIzmeniCenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        public Voce odrediVoce()
        {
            List<Voce> voce = this.voceBusiness.GetAllVoce();
            Voce result = new Voce();
            string nazivVoca = cbVoce.GetItemText(cbVoce.SelectedItem);
            foreach (Voce v in voce)
            {
                if (v.Naziv == nazivVoca)
                {
                    result = v;
                }
            }
            return result;

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cbVoce.SelectedIndex == -1) //znaci da nije izabrano nista
            {
                MessageBox.Show("Odaberite voće u padajućoj listi!");
            }
            else if (string.IsNullOrEmpty(txtCena1klase.Text))
            {
                MessageBox.Show("Morate uneti novu cenu I klase!");
            }
            else if (string.IsNullOrEmpty(txtCena2klase.Text))
            {
                MessageBox.Show("Morate uneti novu cenu II klase!");
            }
            else
            {
                Cena c = new Cena();
                c.CenaIKlase = decimal.Parse(txtCena1klase.Text);
                c.CenaIIKlase = decimal.Parse(txtCena2klase.Text);
                c.Datum = dtpDatum.Value;
                c.FK_IDVoca = odrediVoce().IDVoca;

                if (this.cenaVocaBusiness.UpdateCenuVoca(c))
                {
                    MessageBox.Show("Uspešno!");
                }
                else
                {
                    MessageBox.Show("Neuspešno!");
                }

                dgwCenaVoca.DataSource = this.cenaVocaBusiness.ucitajCeneVoca();

            }
        }

        private void txtCena1klase_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void txtCena2klase_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }
    }
}
