using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Korisnik
    {
        public int idKorisnika { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
    }
}
