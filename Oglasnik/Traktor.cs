using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    public class Traktor : MotornoVozilo, IPriklopnik
    {
        public double SirinaPriklopa { get; set; }
        public bool ImaZlico { get; set; }
        public double MaxDolzinaKompozicije { get; set; }
        public double MaxObremenitevOsi { get; set; }
        public bool ZracneZavore { get; set; }
        public Traktor(string znamka, string model, int letnik, int moc, double cena, Menjalnik menjalnik, string barva, string tipGoriva, int steviloVrat, double sirina, bool zlica, double maxDolzinaKompozicije, double maxObremenitevOsi, bool zracneZavore) : base(znamka, model, letnik, moc, cena, barva, menjalnik, tipGoriva, steviloVrat)
        {
            SirinaPriklopa = sirina;
            ImaZlico = zlica;
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
