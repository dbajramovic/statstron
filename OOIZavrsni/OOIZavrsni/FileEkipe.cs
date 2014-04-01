using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entiteti;
using System.IO;

namespace OOIZavrsni
{
    public partial class FileEkipe : Form
    {
        List<Klub> lista_za_upis = new List<Klub>(0);
        public FileEkipe()
        {
            InitializeComponent();
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
                        string grad = linija.Split(' ')[0];
                        string ime = linija.Split(' ')[1];
                        broj++;
                        Klub Klub_za_unos = new Klub(ime, grad);
                        lista_za_upis.Add(Klub_za_unos);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            foreach (Klub i in lista_za_upis)
            {
                richTextBox1.Text += broj + ". " + i + " \n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Exception n = new Exception();

                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.KlubDAO cd1 = new DAL.DAL.KlubDAO();
                foreach (Klub i in lista_za_upis)
                {
                    i.DajIDKluba = Convert.ToInt32(cd1.create(i));
                }
                MessageBox.Show("Klubovi uspijesno dodani!");
                d1.terminirajKonekciju();
            }
            catch (Exception n)
            {
                MessageBox.Show(Convert.ToString(n));
            }
        }
    }
}
