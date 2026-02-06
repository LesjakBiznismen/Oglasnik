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
