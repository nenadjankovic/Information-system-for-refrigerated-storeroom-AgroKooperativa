using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OtkupBusiness
    {
        private readonly OtkupRepository otkupRepository;

        public OtkupBusiness()
        {
            this.otkupRepository = new OtkupRepository();   
        }

        public bool InsertOtkup(Otkup o)
        {
            if (this.otkupRepository.InsertOtkup(o) > 0)
                return true;
            else
                return false;
        }
    }
}
