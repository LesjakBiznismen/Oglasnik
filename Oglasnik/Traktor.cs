using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    public class Traktor : MotornoVozilo
    {
        public double SirinaPriklopa { get; set; }
        public bool ImaZlico { get; set; }
        public Traktor(string znamka, string model, int letnik, int moc, double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, double sirina, bool zlica) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            SirinaPriklopa = sirina;
            ImaZlico = zlica;
        }
    }
}
