using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Oglasnik
{
    public partial class Form1 : Form
    {
        Denarnica denarnica = new Denarnica(1000000);
        List<Avto> avti = new List<Avto>()
            {
                new Avto("BMW","M3 Comp", 2020, 250, 45000.00, Menjalnik.avtomatski, "črna", "Bencin", 4, "limuzina", false),
                new Avto("Mercedes","C200", 2020, 250, 45000.00, Menjalnik.avtomatski, "črna", "Bencin", 4, "limuzina", false),
                new Avto("Audi","A4 avant", 2020, 250, 45000.00, Menjalnik.avtomatski, "črna", "Bencin", 4, "limuzina", false)
            };

        List<Tovornjak> tovornjaki = new List<Tovornjak>()
            {
                new Tovornjak("MAN", "TGX 18.500", 2021, 500, 95000.00, Menjalnik.avtomatski, "bela", "Dizel", 2, 3.8, "Poličar"),
                new Tovornjak("Scania", "R500", 2022, 500, 110000.00, Menjalnik.avtomatski, "modra", "Dizel", 2, 4.0, "Kiper"),
                new Tovornjak("Mercedes", "Actros", 2019, 480, 85000.00, Menjalnik.avtomatski, "srebrna", "Dizel", 2, 3.9, "Hladilnik")
            };

        List<Traktor> traktorji = new List<Traktor>()
            {
                new Traktor("John Deere", "6155M", 2021, 155, 85000.00, Menjalnik.ročni, "zelena", "Dizel", 2, 2.5, true, 30.0, 1000.0, true),
                new Traktor("New Holland", "T7.210", 2020, 210, 92000.00, Menjalnik.avtomatski, "modra", "Dizel", 2, 3.0, false, 30.0, 1000.0, false),
                new Traktor("Fendt", "724 Vario", 2022, 240, 145000.00, Menjalnik.avtomatski, "zelena", "Dizel", 2, 2.8, true, 30.0, 1000.0, true)
            };

        List<Kombi> kombiji = new List<Kombi>()
            {
                new Kombi("Volkswagen", "Transporter", 2021, 150, 35000.00, Menjalnik.avtomatski, "bela", "Dizel", 4, 1.9, 6000),
                new Kombi("Ford", "Transit Custom", 2020, 130, 28000.00, Menjalnik.ročni, "srebrna", "Dizel", 5, 2.0, 5500),
                new Kombi("Renault", "Traffic", 2019, 145, 24000.00, Menjalnik.ročni, "črna", "Dizel", 4, 1.95, 5800)
            };

        List<Motor> motorji = new List<Motor>()
            {
                new Motor("Yamaha", "MT-07", 2022, 75, 7500.00, Menjalnik.ročni, "siva", "Bencin", 0, 689),
                new Motor("Honda", "CBR1000RR", 2021, 215, 18000.00, Menjalnik.ročni, "rdeča", "Bencin", 0, 1000),
                new Motor("BMW", "R1250 GS", 2023, 136, 22000.00, Menjalnik.ročni, "bela", "Bencin", 0, 1254)
            };

        
        

        public Form1()
        {         
            InitializeComponent();
            NaloziOglaseAvti(avti);
            NaloziOglaseTovornjaki(tovornjaki);
            NaloziOglaseTraktor(traktorji);
            NaloziOglaseKombi(kombiji);
            NaloziOglaseMotor(motorji);

            RadioAvto.Checked = true;
            StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";

            Nosilnost.Hide();
            Priklop.Hide();
            TBpriklop.Hide();
            TBnosilnost.Hide();
            ImaŽlico.Hide();
            TBŠirinaPriklopa.Hide();
            ŠirinaPriklopa.Hide();
            Žlica.Hide();
            Višina.Hide();
            ProstorninaPrtljage.Hide();
            TBprtljaga.Hide();
            TBvisina.Hide();
            ProstorninaCCM.Hide();
            TBprostornina.Hide();
            MotorDataGrid.Hide();
        }

        public void NaloziOglaseAvti(List<Avto> seznamAvtov)
        {
            List<List<string>> OglasiAvto = new List<List<string>>();

            for (int i = 0; i < seznamAvtov.Count; i++)
            {
                OglasiAvto.Add(new List<string>{
                    seznamAvtov[i].Znamka,
                    seznamAvtov[i].Model,
                    seznamAvtov[i].Letnik.ToString(),
                    seznamAvtov[i].Moc.ToString(),
                    (seznamAvtov[i].Cena + seznamAvtov[i].Cena * denarnica.Davek).ToString(),
                    seznamAvtov[i].Menjalnik.ToString(),
                    seznamAvtov[i].Barva,
                    seznamAvtov[i].TipGoriva,
                    seznamAvtov[i].SteviloVrat.ToString(),
                    seznamAvtov[i].Oblika,
                    seznamAvtov[i].Čipiran.ToString()
                });
            }

            DataTable avti = PretvoriPodatkeAvti(OglasiAvto);
            AvtoDataGrid.DataSource = avti;
        }

        public void NaloziOglaseTovornjaki(List<Tovornjak> seznamTovornjakov)
        {
            List<List<string>> OglasiTovornjak = new List<List<string>>();
            for (int i = 0; i < seznamTovornjakov.Count; i++)
            {
                OglasiTovornjak.Add(new List<string>{
                    seznamTovornjakov[i].Znamka,
                    seznamTovornjakov[i].Model,
                    seznamTovornjakov[i].Letnik.ToString(),
                    seznamTovornjakov[i].Moc.ToString(),
                    (seznamTovornjakov[i].Cena + seznamTovornjakov[i].Cena * denarnica.Davek).ToString(),
                    seznamTovornjakov[i].Menjalnik.ToString(),
                    seznamTovornjakov[i].Barva,
                    seznamTovornjakov[i].TipGoriva,
                    seznamTovornjakov[i].SteviloVrat.ToString(),
                    seznamTovornjakov[i].NosilnostTone.ToString(),
                    seznamTovornjakov[i].Priklop
                });
            }

            DataTable tovornjakiTable = PretvoriPodatkeTovornjaki(OglasiTovornjak);
            TovornjakDataGrid.DataSource = tovornjakiTable;
        }

        private DataTable PretvoriPodatkeTovornjaki(List<List<string>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0) return table;

            table.Columns.Add("Znamka");
            table.Columns.Add("Model");
            table.Columns.Add("Letnik");
            table.Columns.Add("Moc");
            table.Columns.Add("Cena");
            table.Columns.Add("Menjalnik");
            table.Columns.Add("Barva");
            table.Columns.Add("Tip Goriva");
            table.Columns.Add("Stevilo Vrat");
            table.Columns.Add("Nosilnost [T]");
            table.Columns.Add("Priklop");

            foreach (var rowList in data)
            {
                DataRow newRow = table.NewRow();

                for (int i = 0; i < rowList.Count; i++)
                {
                    newRow[i] = rowList[i];
                }

                table.Rows.Add(newRow);
            }

            return table;
        }


        private DataTable PretvoriPodatkeAvti(List<List<string>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0) return table;
            table.Columns.Add("Znamka");
            table.Columns.Add("Model");
            table.Columns.Add("Letnik");
            table.Columns.Add("Moc");
            table.Columns.Add("Cena");
            table.Columns.Add("Menjalnik");
            table.Columns.Add("Barva");
            table.Columns.Add("Tip Goriva");
            table.Columns.Add("Stevilo Vrat");
            table.Columns.Add("Oblika");
            table.Columns.Add("Čipiran");


            foreach (var rowList in data)
            {
                DataRow newRow = table.NewRow();


                for (int i = 0; i < rowList.Count; i++)
                {
                    newRow[i] = rowList[i];
                }

                table.Rows.Add(newRow);
            }

            return table;
        }
        public void NaloziOglaseTraktor(List<Traktor> seznamTraktorjev)
        {
            List<List<string>> OglasiTraktor = new List<List<string>>();

            for (int i = 0; i < seznamTraktorjev.Count; i++)
            {
                OglasiTraktor.Add(new List<string>{
            seznamTraktorjev[i].Znamka,
            seznamTraktorjev[i].Model,
            seznamTraktorjev[i].Letnik.ToString(),
            seznamTraktorjev[i].Moc.ToString(),
            (seznamTraktorjev[i].Cena + seznamTraktorjev[i].Cena * denarnica.Davek).ToString(),
            seznamTraktorjev[i].Menjalnik.ToString(),
            seznamTraktorjev[i].Barva,
            seznamTraktorjev[i].TipGoriva,
            seznamTraktorjev[i].SteviloVrat.ToString(),
            seznamTraktorjev[i].SirinaPriklopa.ToString(),
            seznamTraktorjev[i].ImaZlico.ToString()
        });
            }

            DataTable traktorTable = PretvoriPodatkeTraktor(OglasiTraktor);
            TraktorDataGrid.DataSource = traktorTable;
        }

        private DataTable PretvoriPodatkeTraktor(List<List<string>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0) return table;

            table.Columns.Add("Znamka");
            table.Columns.Add("Model");
            table.Columns.Add("Letnik");
            table.Columns.Add("Moc");
            table.Columns.Add("Cena");
            table.Columns.Add("Menjalnik");
            table.Columns.Add("Barva");
            table.Columns.Add("Tip Goriva");
            table.Columns.Add("Stevilo Vrat");
            table.Columns.Add("Širina Priklopa");
            table.Columns.Add("Ima Žlico");

            foreach (var rowList in data)
            {
                DataRow newRow = table.NewRow();
                for (int i = 0; i < rowList.Count; i++)
                {
                    newRow[i] = rowList[i];
                }
                table.Rows.Add(newRow);
            }
            return table;
        }

        public void NaloziOglaseKombi(List<Kombi> seznamKombijev)
        {
            List<List<string>> OglasiKombi = new List<List<string>>();

            for (int i = 0; i < seznamKombijev.Count; i++)
            {
                OglasiKombi.Add(new List<string>{
            seznamKombijev[i].Znamka,
            seznamKombijev[i].Model,
            seznamKombijev[i].Letnik.ToString(),
            seznamKombijev[i].Moc.ToString(),
            (seznamKombijev[i].Cena + seznamKombijev[i].Cena* denarnica.Davek).ToString(),
            seznamKombijev[i].Menjalnik.ToString(),
            seznamKombijev[i].Barva,
            seznamKombijev[i].TipGoriva,
            seznamKombijev[i].SteviloVrat.ToString(),
            seznamKombijev[i].Visina.ToString(),
            seznamKombijev[i].ProstorninaPrtljage.ToString()
        });
            }

            DataTable kombiTable = PretvoriPodatkeKombi(OglasiKombi);
            KombiDataGrid.DataSource = kombiTable;
        }

        private DataTable PretvoriPodatkeKombi(List<List<string>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0) return table;

            table.Columns.Add("Znamka");
            table.Columns.Add("Model");
            table.Columns.Add("Letnik");
            table.Columns.Add("Moc");
            table.Columns.Add("Cena");
            table.Columns.Add("Menjalnik");
            table.Columns.Add("Barva");
            table.Columns.Add("Tip Goriva");
            table.Columns.Add("Stevilo Vrat");
            table.Columns.Add("Višina");
            table.Columns.Add("Prostornina Prtljage");

            foreach (var rowList in data)
            {
                DataRow newRow = table.NewRow();
                for (int i = 0; i < rowList.Count; i++)
                {
                    newRow[i] = rowList[i];
                }
                table.Rows.Add(newRow);
            }
            return table;
        }

        public void NaloziOglaseMotor(List<Motor> seznamMotorjev)
        {
            List<List<string>> OglasiMotor = new List<List<string>>();

            for (int i = 0; i < seznamMotorjev.Count; i++)
            {
                OglasiMotor.Add(new List<string>{
            seznamMotorjev[i].Znamka,
            seznamMotorjev[i].Model,
            seznamMotorjev[i].Letnik.ToString(),
            seznamMotorjev[i].Moc.ToString(),
            (seznamMotorjev[i].Cena + seznamMotorjev[i].Cena * denarnica.Davek).ToString(),
            seznamMotorjev[i].Menjalnik.ToString(),
            seznamMotorjev[i].Barva,
            seznamMotorjev[i].TipGoriva,
            seznamMotorjev[i].SteviloVrat.ToString(),
            seznamMotorjev[i].ProstorninaCcm.ToString()
        });
            }

            DataTable motorTable = PretvoriPodatkeMotor(OglasiMotor);
            MotorDataGrid.DataSource = motorTable;
        }

        private DataTable PretvoriPodatkeMotor(List<List<string>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0) return table;

            table.Columns.Add("Znamka");
            table.Columns.Add("Model");
            table.Columns.Add("Letnik");
            table.Columns.Add("Moc");
            table.Columns.Add("Cena");
            table.Columns.Add("Menjalnik");
            table.Columns.Add("Barva");
            table.Columns.Add("Tip Goriva");
            table.Columns.Add("Stevilo Vrat");
            table.Columns.Add("Prostornina (ccm)");

            foreach (var rowList in data)
            {
                DataRow newRow = table.NewRow();
                for (int i = 0; i < rowList.Count; i++)
                {
                    newRow[i] = rowList[i];
                }
                table.Rows.Add(newRow);
            }
            return table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioAvto_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAvto.Checked)
            {
                AvtoDataGrid.Show();
                
                TovornjakDataGrid.Hide();
                TraktorDataGrid.Hide();
                MotorDataGrid.Hide();
                KombiDataGrid.Hide();

                AvtoDataGrid.Width = 700;
                AvtoDataGrid.Height = 350;
                AvtoDataGrid.Left = 150;
                AvtoDataGrid.Top = 250;

                Oblika.Show();
                Čipiran.Show();
                CBČipiran.Show();
                TBoblika.Show();
            }
            else
            {
                AvtoDataGrid.Hide();
                Oblika.Hide();
                Čipiran.Hide();
                CBČipiran.Hide();
                TBoblika.Hide();
            } 
        }

        private void RadioTovornjak_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTovornjak.Checked)
            {
                TovornjakDataGrid.Show();
                AvtoDataGrid.Hide();
                TraktorDataGrid.Hide();
                MotorDataGrid.Hide();
                KombiDataGrid.Hide();            

                TovornjakDataGrid.Width = 700;
                TovornjakDataGrid.Height = 350;
                TovornjakDataGrid.Left = 150;
                TovornjakDataGrid.Top = 250;

                Nosilnost.Show();
                Priklop.Show();
                TBpriklop.Show();
                TBnosilnost.Show();
                Nosilnost.Location = Oblika.Location;
                Priklop.Location = Čipiran.Location;
                TBpriklop.Location = CBČipiran.Location;
                TBnosilnost.Location = TBoblika.Location;
            }
            else
            {
                TovornjakDataGrid.Hide();
                Nosilnost.Hide();
                Priklop.Hide();
                TBpriklop.Hide();
                TBnosilnost.Hide();
            }
            
        }

        private void RadioTraktor_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTraktor.Checked)
            {
                TraktorDataGrid.Show();
                AvtoDataGrid.Hide();
                TovornjakDataGrid.Hide();
                MotorDataGrid.Hide();
                KombiDataGrid.Hide();

                TraktorDataGrid.Width = 700;
                TraktorDataGrid.Height = 350;
                TraktorDataGrid.Left = 150;
                TraktorDataGrid.Top = 250; 

                ŠirinaPriklopa.Show();
                Žlica.Show();
                ImaŽlico.Show();
                TBŠirinaPriklopa.Show();
                ŠirinaPriklopa.Location = Oblika.Location;
                Žlica.Location = Čipiran.Location;
                ImaŽlico.Location = CBČipiran.Location;
                TBŠirinaPriklopa.Location = TBoblika.Location;
            }
            else
            {
                TraktorDataGrid.Hide();
                ImaŽlico.Hide();
                TBŠirinaPriklopa.Hide();
                ŠirinaPriklopa.Hide();
                Žlica.Hide();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                KombiDataGrid.Show();
                AvtoDataGrid.Hide();
                TraktorDataGrid.Hide();
                MotorDataGrid.Hide();
                TovornjakDataGrid.Hide();

                KombiDataGrid.Width = 700;
                KombiDataGrid.Height = 350;
                KombiDataGrid.Left = 150;
                KombiDataGrid.Top = 250;

                Višina.Show();
                ProstorninaPrtljage.Show();
                TBprtljaga.Show();
                TBvisina.Show();
                Višina.Location = Oblika.Location;
                ProstorninaPrtljage.Location = Čipiran.Location;
                TBprtljaga.Location = CBČipiran.Location;
                TBvisina.Location = TBoblika.Location;
            }
            else
            {
                KombiDataGrid.Hide();
                Višina.Hide();
                ProstorninaPrtljage.Hide();
                TBprtljaga.Hide();
                TBvisina.Hide();
            }
        }

        private void RadioMotor_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioMotor.Checked)
            {
                MotorDataGrid.Show();
                AvtoDataGrid.Hide();
                TraktorDataGrid.Hide();
                TovornjakDataGrid.Hide();
                KombiDataGrid.Hide();

                ProstorninaCCM.Show();
                TBprostornina.Show();
                ProstorninaCCM.Location = Oblika.Location;
                TBprostornina.Location = TBoblika.Location;

                MotorDataGrid.Width = 700;
                MotorDataGrid.Height = 350;
                MotorDataGrid.Left = 150;
                MotorDataGrid.Top = 250;
            }
            else 
            {
                ProstorninaCCM.Hide();
                TBprostornina.Hide();
                MotorDataGrid.Hide();
            } 
        }

        private void DodajOglas_Click(object sender, EventArgs e)
        {
            if (RadioAvto.Checked)
            {
                string tipGoriva = " ";

                switch (CBTipGoriva.SelectedIndex)
                {
                    case 0: tipGoriva = "dizel"; break;
                    case 1: tipGoriva = "bencin"; break;
                }

                bool čip = false;
                if (CBČipiran.SelectedIndex == 0) čip = true;

                switch (CBMenjalnik.SelectedIndex)
                {
                    case 0: avti.Add(new Avto(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.avtomatski, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), TBoblika.Text, čip)); break;
                    case 1: avti.Add(new Avto(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.ročni, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), TBoblika.Text, čip)); break;
                }

                NaloziOglaseAvti(avti);
            };

            if (RadioTovornjak.Checked)
            {
                string tipGoriva = " ";

                switch (CBTipGoriva.SelectedIndex)
                {
                    case 0: tipGoriva = "dizel"; break;
                    case 1: tipGoriva = "bencin"; break;
                }
                
                switch (CBMenjalnik.SelectedIndex)
                {
                    case 0: tovornjaki.Add(new Tovornjak(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.avtomatski, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBnosilnost.Text), TBpriklop.Text)); break;
                    case 1: tovornjaki.Add(new Tovornjak(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.ročni, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBnosilnost.Text), TBpriklop.Text)); break;
                }

                NaloziOglaseTovornjaki(tovornjaki);
            }

            if (radioButton4.Checked)
            {
                string tipGoriva = " ";

                switch (CBTipGoriva.SelectedIndex)
                {
                    case 0: tipGoriva = "dizel"; break;
                    case 1: tipGoriva = "bencin"; break;
                }

                switch (CBMenjalnik.SelectedIndex)
                {
                    case 0: kombiji.Add(new Kombi(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.avtomatski, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBvisina.Text), int.Parse(TBprtljaga.Text))); break;
                    case 1: kombiji.Add(new Kombi(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.ročni, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBvisina.Text), int.Parse(TBprtljaga.Text))); break;
                }

                NaloziOglaseKombi(kombiji);
            }

            if (RadioMotor.Checked)
            {
                string tipGoriva = " ";

                switch (CBTipGoriva.SelectedIndex)
                {
                    case 0: tipGoriva = "dizel"; break;
                    case 1: tipGoriva = "bencin"; break;
                }

                switch (CBMenjalnik.SelectedIndex)
                {
                    case 0: motorji.Add(new Motor(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.avtomatski, TBbarva.Text, tipGoriva, 0,  int.Parse(TBprostornina.Text))); break;
                    case 1: motorji.Add(new Motor(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.ročni, TBbarva.Text, tipGoriva, 0,  int.Parse(TBprostornina.Text))); break;
                }

                NaloziOglaseMotor(motorji);
            }

            if (RadioTraktor.Checked)
            {
                string tipGoriva = " ";

                switch (CBTipGoriva.SelectedIndex)
                {
                    case 0: tipGoriva = "dizel"; break;
                    case 1: tipGoriva = "bencin"; break;
                }

                bool žlica = false;
                if (CBČipiran.SelectedIndex == 0) žlica = true;

                switch (CBMenjalnik.SelectedIndex)
                {
                    case 0: traktorji.Add(new Traktor(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.avtomatski, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBŠirinaPriklopa.Text), žlica, 30.0, 1000.0, true)); break;
                    case 1: traktorji.Add(new Traktor(TBznamka.Text, TBmodel.Text, int.Parse(TBletnik.Text), int.Parse(TBMoč.Text), double.Parse(TBcena.Text), Menjalnik.ročni, TBbarva.Text, tipGoriva, int.Parse(TBŠteviloVrat.Text), double.Parse(TBŠirinaPriklopa.Text), žlica, 30.0, 1000.0, true)); break;
                }

                NaloziOglaseTraktor(traktorji);
            }
            ;
        }

        private void KupiVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                string cena = AvtoDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                double plačilo = double.Parse(cena);
                denarnica.Plačaj(plačilo);
                StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";
                AvtoDataGrid.ClearSelection();
            }
            catch
            {
                try
                {
                    string cena = TovornjakDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                    double plačilo = double.Parse(cena);
                    denarnica.Plačaj(plačilo);
                    StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";
                    TovornjakDataGrid.ClearSelection();
                }
                catch
                {
                    try
                    {
                        string cena = KombiDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                        double plačilo = double.Parse(cena);
                        denarnica.Plačaj(plačilo);
                        StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";
                        KombiDataGrid.ClearSelection();
                    }
                    catch
                    {
                        try
                        {
                            string cena = TraktorDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                            double plačilo = double.Parse(cena);
                            denarnica.Plačaj(plačilo);
                            StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";
                            TraktorDataGrid.ClearSelection();
                        }
                        catch
                        {
                            try
                            {
                                string cena = MotorDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                                double plačilo = double.Parse(cena);
                                denarnica.Plačaj(plačilo);
                                StanjeNaDenarnici.Text = denarnica.Stanje.ToString() + "$";
                                MotorDataGrid.ClearSelection();
                            }
                            catch
                            {
                                MessageBox.Show("Izberi vozilo, ki ga želiš kupiti");
                            }
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
