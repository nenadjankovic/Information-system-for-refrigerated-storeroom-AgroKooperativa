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
    public partial class UkupnoStanje : Form
    {
        private readonly VoceBusiness voceBusiness;
        private readonly ProizvodjacBusiness proizvodjacBusiness;
        private readonly OtkupBusiness otkupBusiness;
        private readonly CenaVocaBusiness cenaVocaBusiness;
        private readonly AmbalazaBusiness ambalazaBusiness;
        private readonly AvansBusiness avansBusiness;

        public UkupnoStanje()
        {
            this.proizvodjacBusiness = new ProizvodjacBusiness();
            this.voceBusiness = new VoceBusiness();
            this.otkupBusiness = new OtkupBusiness();
            this.cenaVocaBusiness = new CenaVocaBusiness();
            this.ambalazaBusiness = new AmbalazaBusiness();
            this.avansBusiness = new AvansBusiness();
            InitializeComponent();
        }

        private void UkupnoStanje_Load(object sender, EventArgs e)
        {
            fillCombo();
            lbldin.Hide();
            lbldin2.Hide();
            lbldin3.Hide();

        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (cbProizvodjac.SelectedIndex == -1) //znaci da nije izabrano nista
            {
                MessageBox.Show("Odaberite proizvođača u padajućoj listi!");
            }
            else
            {
                string pr = cbProizvodjac.GetItemText(cbProizvodjac.SelectedItem); //ceo combo
                string idPr = pr.Substring(0, pr.IndexOf(" ")); //odvajanje samo id
                int idProizvodjaca = Convert.ToInt32(idPr);

                List<Voce> voce = this.voceBusiness.GetAllVoce();
                List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
                List<Otkup> otkup = this.otkupBusiness.GetAllOtkup();
                List<Cena> cene = this.cenaVocaBusiness.GetAllCena();


                decimal kolVilamet1 = 0;
                decimal kolVilamet2 = 0;
                decimal kolMiker1 = 0;
                decimal kolMiker2 = 0;
                decimal kolFertodi1 = 0;
                decimal kolFertodi2 = 0;
                decimal kolGlen1 = 0;
                decimal kolGlen2 = 0;
                decimal kolPolka1 = 0;
                decimal kolPolka2 = 0;


                foreach (Otkup o in otkup)
                {
                    if (o.idProizvodjaca == idProizvodjaca)
                    {
                        if (o.IDVoca == 1)
                        {
                            kolVilamet1 += o.NetoKolicinaIKlase;
                            kolVilamet2 += o.NetoKolicinaIIKlase;

                        }
                        else if (o.IDVoca == 2)
                        {
                            kolMiker1 += o.NetoKolicinaIKlase;
                            kolMiker2 += o.NetoKolicinaIIKlase;
                        }
                        else if (o.IDVoca == 3)
                        {
                            kolFertodi1 += o.NetoKolicinaIKlase;
                            kolFertodi2 += o.NetoKolicinaIIKlase;
                        }
                        else if (o.IDVoca == 4)
                        {
                            kolGlen1 += o.NetoKolicinaIKlase;
                            kolGlen2 += o.NetoKolicinaIIKlase;
                        }
                        else if (o.IDVoca == 5)
                        {
                            kolPolka1 += o.NetoKolicinaIKlase;
                            kolPolka2 += o.NetoKolicinaIIKlase;
                        }

                    }

                }

                decimal sumaVilamet1 = 0;
                decimal sumaVilamet2 = 0;
                decimal sumaMiker1 = 0;
                decimal sumaMiker2 = 0;
                decimal sumaFertodi1 = 0;
                decimal sumaFertodi2 = 0;
                decimal sumaGlen1 = 0;
                decimal sumaGlen2 = 0;
                decimal sumaPolka1 = 0;
                decimal sumaPolka2 = 0;

                foreach (Cena c in cene)
                {
                    if (c.FK_IDVoca == 1)
                    {
                        sumaVilamet1 = kolVilamet1 * c.CenaIKlase;
                        sumaVilamet2 = kolVilamet2 * c.CenaIIKlase;
                    }
                    else if (c.FK_IDVoca == 2)
                    {
                        sumaMiker1 = kolMiker1 * c.CenaIKlase;
                        sumaMiker2 = kolMiker2 * c.CenaIIKlase;
                    }
                    else if (c.FK_IDVoca == 3)
                    {
                        sumaFertodi1 = kolFertodi1 * c.CenaIKlase;
                        sumaFertodi2 = kolFertodi2 * c.CenaIIKlase;
                    }
                    else if (c.FK_IDVoca == 4)
                    {
                        sumaGlen1 = kolGlen1 * c.CenaIKlase;
                        sumaGlen2 = kolGlen2 * c.CenaIIKlase;
                    }
                    else if (c.FK_IDVoca == 5)
                    {
                        sumaPolka1 = kolPolka1 * c.CenaIKlase;
                        sumaPolka2 = kolPolka2 * c.CenaIIKlase;
                    }
                }
                decimal ukupnaSuma = Math.Round((sumaVilamet1 + sumaVilamet2 + sumaMiker1 + sumaMiker2 + sumaFertodi1 + sumaFertodi2 + sumaGlen1 + sumaGlen2 + sumaPolka1 + sumaPolka2), 2);


                lblPredato1.Text = Convert.ToString(ukupnaSuma);

                List<Avansi> avansi = this.avansBusiness.GetAllAvans();
                decimal sumaAvansa = 0;

                foreach (Avansi a in avansi)
                {
                    if (a.idProizvodjaca == idProizvodjaca)
                    {
                        sumaAvansa += a.Suma;
                    }
                }

                lblStanjeAvansa.Text = (Convert.ToString(sumaAvansa));
                decimal saldo = ukupnaSuma - sumaAvansa;
                if (saldo < 0)
                {
                    lblSaldo.ForeColor = Color.Red;
                    gpSaldo.ForeColor = Color.Red;
                    lblSaldo.Text = Convert.ToString(saldo);

                }
                else
                {
                    gpSaldo.ForeColor = Color.Green;
                    lblSaldo.ForeColor = Color.Green;
                    lblSaldo.Text = Convert.ToString(saldo);
                }


                List<Ambalaza> ambalaze = this.ambalazaBusiness.GetAllAmbalaza();
                int sumaIz = 0;
                int sumaVr = 0;
                foreach (Ambalaza a in ambalaze)
                {
                    if (a.idProizvodjaca == idProizvodjaca)
                    {
                        sumaIz = sumaIz + a.izdato;
                        sumaVr += a.vraceno;
                    }
                }
                lblIzdato.Text = (Convert.ToString(sumaIz));

                lblVraceno.Text = Convert.ToString(sumaVr);
                decimal saldoAmb = sumaIz - sumaVr;
                if (saldoAmb < 0)
                {
                    lblSaldoAm.ForeColor = Color.Red;
                    lblSaldoAm.Text = Convert.ToString(saldoAmb);
                }
                else
                {

                    lblSaldoAm.ForeColor = Color.Green;
                    lblSaldoAm.Text = Convert.ToString(saldoAmb);
                }

                lbldin.Show();
                lbldin2.Show();
                lbldin3.Show();

            }

        }

        public void fillCombo()
        {
            List<Proizvodjac> proizvodjaci = this.proizvodjacBusiness.GetAllProizvodjac();
            foreach (Proizvodjac p in proizvodjaci)
            {
                cbProizvodjac.Items.Add(p.idProizvodjaca + " " + p.ime + " " + p.prezime);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
