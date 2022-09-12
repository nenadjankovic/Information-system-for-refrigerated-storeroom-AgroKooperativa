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
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void btnProizvodjaci_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Proizvodjaci();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void btnCenaVoca_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new CenaVoca();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void Meni_Load(object sender, EventArgs e)
        {

        }
    }
}
