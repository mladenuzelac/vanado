using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vanado.Models;

namespace vanado.DAO
{
    interface IStrojRepository
    {
        IEnumerable<Stroj> DohvatiSveStrojeve();
        void IzbrisiStroj(int id);
        void AzurirajStroj(int id, Stroj stroj);

    }
}
