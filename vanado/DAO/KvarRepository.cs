using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vanado.Models;

namespace vanado.DAO
{
    public class KvarRepository : IKvarRepository
    {

        public KvarRepository()
        {

        }



        public Kvar AzurirajKvar(int id, Kvar kvar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kvar> DohvatiSveKvarove()
        {
            throw new NotImplementedException();
        }

        public void IzbrisiKvar()
        {
            throw new NotImplementedException();
        }

        public Kvar PromijeniStanjeKvara(int id)
        {
            throw new NotImplementedException();
        }
    }
}
