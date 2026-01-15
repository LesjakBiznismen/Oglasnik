using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    class Denarnica
    {
        public double Stanje { get; set; }
        private const double davek = 0.15;

        public double Davek 
        { 
            get { return davek; } 
        }

        public Denarnica(double stanje)
        {
            Stanje = stanje;
        }

        public void Polog(double n)
        {
            Stanje += n;
        }
        public void Plačaj(double n)
        {
            Stanje -= n;
        }
    }
}
