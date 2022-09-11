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
    public class VoceBusiness
    {
        private readonly VoceRepository voceRepository;
        
        public VoceBusiness()
        {
            this.voceRepository = new VoceRepository();
        }

        public DataTable ucitajVoce()
        {
            return this.voceRepository.ucitajVoce();
        }

        public List<Voce> GetAllVoce()
        {
            return this.voceRepository.GetAllVoce();
        }
    }
}
