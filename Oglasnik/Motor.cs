using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    public class Motor : MotornoVozilo
    {
        public int ProstorninaCcm { get; set; }

        public Motor(string znamka, string model, int letnik, int moc, double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, int prostorninaCcm) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            ProstorninaCcm = prostorninaCcm;
        }
    }
}
