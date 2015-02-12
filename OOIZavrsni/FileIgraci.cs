using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL.Entiteti;

namespace OOIZavrsni
{
    public partial class FileIgraci : Form
    {
        List<Igrac> lista_za_upis = new List<Igrac>(0);
        List<Igrac_GA> lista_Za_upis_GA = new List<Igrac_GA>(0);
        public FileIgraci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string linija = "";
            int broj = 0;
            bool ide = true;
            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (ide)
                    {
                        linija = sr.ReadLine();
                        if (linija == null) ide = false;
                        string prezime = linija.Split(',')[0];
                        string ime = linija.Split(',')[1];
                        broj++;
                        Igrac igrac_za_unos = new Igrac(ime, prezime);
                        Igrac_GA igrac_za_unos_GA = new Igrac_GA();
                        igrac_za_unos_GA.Daj_Ime_i_prezime = ime + " " + prezime;
                        lista_za_upis.Add(igrac_za_unos);
                        lista_Za_upis_GA.Add(igrac_za_unos_GA);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            foreach (Igrac i in lista_za_upis)
            {
                richTextBox1.Text += lista_za_upis.IndexOf(i) + ". " + i + " \n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_GA.Checked) {
                try
                {
                    Exception n = new Exception();

                    DAL.DAL d1 = DAL.DAL.Instanca;
                    d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                    DAL.DAL.Igrac_GADAO cd1 = new DAL.DAL.Igrac_GADAO();
                    foreach (Igrac_GA i in lista_Za_upis_GA)
                    {
                        i.Daj_ID = Convert.ToInt32(cd1.create(i));
                    }
                    MessageBox.Show("Igraci uspijesno dodani!");
                    d1.terminirajKonekciju();
                }
                catch (Exception n)
                {
                    MessageBox.Show(Convert.ToString(n));
                }
            }
            else
            {
                try
                {
                    Exception n = new Exception();

                    DAL.DAL d1 = DAL.DAL.Instanca;
                    d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                    DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
                    foreach (Igrac i in lista_za_upis)
                    {
                        i.Daj_Igrac_ID = Convert.ToInt32(cd1.create(i));
                    }
                    MessageBox.Show("Igraci uspijesno dodani!");
                    d1.terminirajKonekciju();
                }
                catch (Exception n)
                {
                    MessageBox.Show(Convert.ToString(n));
                }
            }
        }
    }
}
