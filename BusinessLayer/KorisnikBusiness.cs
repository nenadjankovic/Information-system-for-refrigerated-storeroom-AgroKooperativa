using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public bool InsertKorisnik(Korisnik k)
        {
            if (this.korisnikRepository.InsertKorisnik(k) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable loginData(string username, string password)
        {
            return this.korisnikRepository.loginData(username, password);
        }

        public DataTable ProveraPonavljanjaKorisnickogImena(string username)
        {
            return this.korisnikRepository.ProveraPonavljanjaKorisnickogImena(username);
        }

    }
}
