using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    public enum Menjalnik { ročni, avtomatski }

    

    public abstract class MotornoVozilo
    {
        public static int steviloVozil = 0;

        private string znamka;
        private string model;
        private int letnik;
        private int moc;
        private double cena;
        private string barva;
        private string tipGoriva;
        private int steviloVrat;

     
        public Menjalnik Menjalnik { get; set; }
        

        public string Znamka
        {
            get { return znamka; }
            set { znamka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Letnik
        {
            get { return letnik; }
            set
            {
                if (value < 0) letnik = 0;
                else letnik = value;
            }
        }

        public int Moc
        {
            get { return moc; }
            set
            {
                if (value < 0) moc = 0;
                else moc = value;
            }
        }

        public double Cena
        {
            get { return cena; }
            set
            {
                if (value < 0) cena = 0;
                else cena = value;
            }
        }

        public string Barva
        {
            get { return barva; }
            set { barva = value; }
        }

        public string TipGoriva
        {
            get { return tipGoriva; }
            set { tipGoriva = value; }
        }

        public int SteviloVrat
        {
            get { return steviloVrat; }
            set
            {
                if (value < 0) steviloVrat = 0;
                else steviloVrat = value;
            }
        }

        public MotornoVozilo(string znamka, string model, int letnik, int moc, double cena, string barva, Menjalnik menjalnik, string tipGoriva, int steviloVrat)
        {
            Znamka = znamka;
            Model = model;
            Letnik = letnik;
            Moc = moc;
            Cena = cena;
            Barva = barva;
            Menjalnik = menjalnik;
            TipGoriva = tipGoriva;
            SteviloVrat = steviloVrat;
            steviloVozil += 1;
        }

        ~MotornoVozilo()
        {
            steviloVozil -= 1;
        }
    }
}
