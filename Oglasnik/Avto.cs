using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oglasnik
{
    
    public class Avto : MotornoVozilo
    {
        public string Oblika { get; set; }
        public bool Čipiran { get; set; }

        public Avto(string znamka, string model, int letnik, int moc,  double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, string oblika, bool čipiran) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            Oblika = oblika;
            Čipiran = čipiran;
        }
    }
}
