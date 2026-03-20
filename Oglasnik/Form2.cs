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
    public partial class Form2: Form
    {
        private MotornoVozilo vozilo;

        public Form2(MotornoVozilo vozilo)
        {
            InitializeComponent();
            this.vozilo = vozilo;
            PrikaziPodrobnosti();
        }

        private void PrikaziPodrobnosti()
        {
            if (vozilo == null)
            {
                MessageBox.Show("Podatki o vozilu niso na voljo.");
                Close();
                return;
            }

            Text = $"Podrobnosti - {vozilo.Znamka} {vozilo.Model}";
            label1.Text = $"{vozilo.Znamka} {vozilo.Model}";
            letoizd.Text = $"Leto izdelave: {vozilo.Letnik}";
            Barva.Text = $"Barva: {vozilo.Barva}";
            label5.Text = $"Moč: {vozilo.Moc} KS";
            label4.Text = $"Menjalnik: {vozilo.Menjalnik}";
            label9.Text = $"Tip goriva: {vozilo.TipGoriva}";
            label8.Text = vozilo.SteviloVrat > 0
                ? $"Število vrat: {vozilo.SteviloVrat}\n{vozilo.VrniPosebnost()}"
                : vozilo.VrniPosebnost();
        }

    }
}
