using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    public class Kombi : MotornoVozilo
    {
        public double Visina { get; set; }
        public int ProstorninaPrtljage { get; set; }

        public Kombi(string znamka, string model, int letnik, int moc, double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, double visina, int prostorninaPrtljage) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            Visina = visina;
            ProstorninaPrtljage = prostorninaPrtljage;
        }
    }
}
