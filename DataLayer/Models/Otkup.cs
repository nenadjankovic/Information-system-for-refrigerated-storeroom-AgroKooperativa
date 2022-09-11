using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Otkup
    {
        public int idOtkupa { get; set; }
        public decimal KolicinaIKlase { get; set; }
        public decimal KolicinaIIKlase { get; set; }
        public DateTime Datum { get; set; }
        public int IDVoca { get; set; }
        public int idProizvodjaca { get; set; }
    }
}
