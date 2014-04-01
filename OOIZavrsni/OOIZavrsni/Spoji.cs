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
    public partial class Spoji : Form
    {
        Klub selektirani_klub = new Klub("N/A","N/A");
        Igrac selektirani_igrac = new Igrac("N/A", "N/A");
        public Spoji()
        {
            InitializeComponent();
        }

        private void Spoji_Load(object sender, EventArgs e)
        {
            List<Klub> Klubi = new List<Klub>();
            List<Igrac> Igraci_temp = new List<Igrac>();
            List<Igrac> Igraci = new List<Igrac>();
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.KlubDAO cd1 = new DAL.DAL.KlubDAO();
            Klubi = cd1.getAll();
            d1.terminirajKonekciju();
            listBox1.DataSource = Klubi;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd2 = new DAL.DAL.IgracDAO();
            Igraci_temp = cd2.getAll();
            d1.terminirajKonekciju();
            foreach (Igrac i in Igraci_temp)
            {
                if (i.Daj_Ekipa_ID == 0)
                    Igraci.Add(i);
            }
            listBox2.DataSource = Igraci;
            selektirani_klub = (Klub)(listBox1.SelectedItem);
            selektirani_igrac = (Igrac)(listBox2.SelectedItem);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirani_klub = (Klub)(listBox1.SelectedItem);
            l_ekipa_ime.Text = selektirani_klub.Ime_KLuba;
            l_ekipa_grad.Text = selektirani_klub.grad_Kluba;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ime_kluba_temp;
            selektirani_igrac = (Igrac)(listBox2.SelectedItem);
            l_igrac_ime.Text = selektirani_igrac.Ime_Igraca;
            l_igrac_prezime.Text = selektirani_igrac.Prezime_Igraca;
            DAL.DAL d1 = DAL.DAL.Instanca;
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            ime_kluba_temp = cd1.GetTeamName(selektirani_igrac);
            d1.terminirajKonekciju();
            if(selektirani_igrac.Daj_Ekipa_ID==0)
                l_igrac_ekipa.Text = "Free Agent";
            else
                l_igrac_ekipa.Text = Convert.ToString(selektirani_igrac.Daj_Ekipa_ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selektirani_klub.Broj_Igraca >= 12)
                    throw new Exception("Previše Igrača!");
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
                long a = cd1.MergeTeamAndPlayer(selektirani_igrac, selektirani_klub);
                d1.terminirajKonekciju();
                MessageBox.Show("Igrač " + selektirani_igrac + "je uspiješno dodan u momčad " + selektirani_klub + "!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
