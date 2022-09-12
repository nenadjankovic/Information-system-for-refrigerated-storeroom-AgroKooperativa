using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Avansi
    {
        public int idAvans { get; set; }
        public DateTime Datum { get; set; }
        public decimal Suma { get; set; }
        public int idProizvodjaca { get; set; }
    }
}
