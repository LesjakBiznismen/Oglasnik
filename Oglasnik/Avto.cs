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

        public override void PodatkiVozilaDef(out string znamka, out string model, out int letnik, out int moc, out double cena, out string barva, out Menjalnik menjalnik, out string tipGoriva, out int steviloVrat)
        {
            znamka = Znamka;
            model = Model;
            letnik = Letnik;
            moc = Moc;
            cena = Cena;
            barva = Barva;
            menjalnik = Menjalnik;
            tipGoriva = TipGoriva;
            steviloVrat = SteviloVrat;
        }
    }
}
