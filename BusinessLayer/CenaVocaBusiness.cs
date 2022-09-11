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
        private readonly CenaVocaRepository cenaVocaRepository;
        public CenaVocaBusiness()
        {
            this.cenaVocaRepository = new CenaVocaRepository();
        }
        public DataTable ucitajCeneVoca()
        {
            return this.cenaVocaRepository.ucitajCeneVoca();
        }

        public bool UpdateCenuVoca(Cena c)
        {
            if (this.cenaVocaRepository.UpdateCenuVoca(c) > 0)
                return true;
            else
                return false;
        }
    }
}
