using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Proizvodjac
    {
        public int idProizvodjaca { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string mesto { get; set; }
        public string telefon { get; set; }
        public long BPG { get; set; }
    }
}
