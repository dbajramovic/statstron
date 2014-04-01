using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOIZavrsni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void igraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaIgraca li = new ListaIgraca();
            li.Show();
        }

        private void igračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosIgraca ui = new UnosIgraca();
            ui.Show();
        }

        private void učutajIzTekstaIgračeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIgraci fi = new FileIgraci();
            fi.Show();
        }

        private void učitajEkipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileEkipe fe = new FileEkipe();
            fe.Show();
        }

        private void ekipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEkipa le = new ListaEkipa();
            le.Show();
        }

        private void spojiIgračeIKluboveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spoji s = new Spoji();
            s.Show();
        }

        private void pozicijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodaPoziciju dp = new DodaPoziciju();
            dp.Show();
        }

        private void sezonskePodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSezona fs = new FileSezona();
            fs.Show();
        }

        private void sezoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledSezona ps = new PregledSezona();
            ps.Show();
        }
    }
}
