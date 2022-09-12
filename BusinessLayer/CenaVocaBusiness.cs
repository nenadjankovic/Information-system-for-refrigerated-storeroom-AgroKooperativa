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
    public class CenaVocaBusiness
    {
        private readonly CenaRepository cenaRepository;
        public CenaVocaBusiness()
        {
            this.cenaRepository = new CenaRepository();
        }                                                       
        public DataTable ucitajCeneVoca()
        {
            return this.cenaRepository.ucitajCeneVoca();
        }

        public bool UpdateCenuVoca(Cena c)
        {
            if (this.cenaRepository.UpdateCenuVoca(c) > 0)
                return true;
            else
                return false;
        }

        public List<Cena> GetAllCena()
        {
            return this.cenaRepository.GetAllCena();
        }
    }
}
