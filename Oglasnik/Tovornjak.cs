using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oglasnik
{
    public class Tovornjak : MotornoVozilo, IPriklopnik
    {
        public double NosilnostTone { get; set; }
        public string Priklop { get; set; }

        public double MaxDolzinaKompozicije { get; set; }
        public double MaxObremenitevOsi { get; set; }
        public bool ZracneZavore { get; set; }

        public Tovornjak(string znamka, string model, int letnik, int moc, double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, double nosilnost, string priklop) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            NosilnostTone = nosilnost;
            Priklop = priklop;
        }
    }
}
