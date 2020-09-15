using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vanado.Models
{
    interface IKvarRepository
    {
        IEnumerable<Kvar> DohvatiSveKvarove();
        void IzbrisiKvar();
        Kvar AzurirajKvar(int id, Kvar kvar);
        Kvar PromijeniStanjeKvara(int id);
    }
}
