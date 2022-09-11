using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KorisnikBusiness
    {
        private readonly KorisnikRepository korisnikRepository;

        public KorisnikBusiness()
        {
            this.korisnikRepository = new KorisnikRepository();
        }

        public List<Korisnik> GetAllKorisnici()
        {
            return this.korisnikRepository.GetAllKorisnici();
        }
    }
}
