using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Cena
    {
        public int idCeneVoca { get; set; }
        public decimal CenaIKlase { get; set; }
        public decimal CenaIIKlase { get; set; }
        public DateTime Datum { get; set; }
        public int FK_IDVoca { get; set; }
    }
}
