using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vanado.Models
{
    public class Kvar
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string[] datoteka { get; set; }
        public bool status { get; set; }
        public DateTime vrijemePrijave { get; set; }
        public Stroj stroj { get; set; }
    }
}
