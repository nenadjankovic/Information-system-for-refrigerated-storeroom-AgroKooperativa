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
    public class AvansBusiness
    {
        private readonly AvansRepository avansRepository;

        public AvansBusiness()
        {
            this.avansRepository = new AvansRepository();
        }

        public List<Avansi> GetAllAvans()
        {
            return this.avansRepository.GetAllAvans();
        }

        public bool InsertAvans(Avansi a)
        {
            if (this.avansRepository.InsertAvans(a) > 0)
                return true;
            else
                return false;
        }

        public DataTable ucitajAvans()
        {
            return this.avansRepository.ucitajAvans();
        }

        public bool UpdateAvans(Avansi a)
        {
            if (this.avansRepository.UpdateAvans(a) > 0)
                return true;
            return false;
        }
    }
}
