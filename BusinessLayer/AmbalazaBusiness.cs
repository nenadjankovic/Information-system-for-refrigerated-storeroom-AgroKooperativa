using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AmbalazaBusiness
    {
        private readonly AmbalazaRepository ambalazaRepository;

        public AmbalazaBusiness()
        {
            this.ambalazaRepository = new AmbalazaRepository();
        }

        public List<Ambalaza> GetAllAmbalaza()
        {
            return this.ambalazaRepository.GetAllAmbalaza();
        }

        public bool InsertAmbalaza(Ambalaza a)
        {
            if (this.ambalazaRepository.InsertAmbalaza(a) > 0)
                return true;
            else
                return false;
        }
    }
}
