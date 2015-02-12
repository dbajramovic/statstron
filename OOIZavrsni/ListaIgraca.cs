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

namespace OOIZavrsni
{
    public partial class ListaIgraca : Form
    {
        List<Igrac> Igraci = new List<Igrac>();
        List<Igrac> templista = new List<Igrac>();
        public ListaIgraca()
        {
            InitializeComponent();
            
        }
        private void ListaIgraca_Load(object sender, EventArgs e)
        {
            int PG=0, SG=0, SF=0, PF=0, C=0,NA=0,ukupno=0;
            try
            {
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
                Igraci = cd1.getAll();
                d1.terminirajKonekciju();
                listBox1.DataSource = Igraci;
                foreach (Igrac i in Igraci)
                {
                    if (i.DajPozicija == "PG")
                        PG++;
                    if (i.DajPozicija == "SG")
                        SG++;
                    if (i.DajPozicija == "SF")
                        SF++;
                    if (i.DajPozicija == "PF")
                        PF++;
                    if (i.DajPozicija == "C")
                        C++;
                    if (i.DajPozicija == "N/A")
                        NA++;
                    ukupno++;
                }
                label2.Text = "Od " + ukupno + " igrača, " + PG + " su PG, " + SG + " su SG, " + SF + " su SF, " + PF + " su PF, " + C + " su C, a " + NA + " nisu jos obrađeni.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            templista.Clear();
            foreach (Igrac i in Igraci)
            {
                String a = i.Ime_Igraca +" "+ i.Prezime_Igraca;
                if (a.Contains(textBox1.Text))
                    templista.Add(i);
            }
            listBox1.DataSource = null;
            listBox1.DataSource = templista;
        }
    }
}
