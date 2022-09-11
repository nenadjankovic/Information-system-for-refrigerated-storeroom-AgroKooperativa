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
    public class ProizvodjacBusiness
    {
        private readonly ProizvodjacRepository proizvodjacRepository;

        public ProizvodjacBusiness()
        {
            this.proizvodjacRepository = new ProizvodjacRepository();
        }
        public List<Proizvodjac> GetAllProizvodjac()
        {
            return this.proizvodjacRepository.GetAllProizvodjaci();
        }

        public bool InsertProzvodjac(Proizvodjac p)
        {
            if (this.proizvodjacRepository.InsertProizvodjac(p) > 0)
                return true;
            else
                return false;
        }

        public bool DeleteProizovdjac(int id)
        {
            if (this.proizvodjacRepository.DeleteProizvodjac(id) > 0)
                return true;
            else
                return false;
        }

        public DataTable ucitajProizvodjace()
        {

            return this.proizvodjacRepository.ucitajProizvodjace();
        }
    }
}
