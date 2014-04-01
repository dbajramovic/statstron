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
    public partial class DodaPoziciju : Form
    {
        List<Igrac> Igraci = new List<Igrac>();
        List<Igrac> Pom_Igraci = new List<Igrac>();
        public DodaPoziciju()
        {
            InitializeComponent();
        }

        private void DodaPoziciju_Load(object sender, EventArgs e)
        {
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            Igraci = cd1.getAll();
            d1.terminirajKonekciju();
            foreach(Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Igraci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Igrac selektirani_igrac = (Igrac)(listBox1.SelectedItem);
            selektirani_igrac.DajPozicija = "PG";
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            selektirani_igrac = cd1.update(selektirani_igrac);
            DAL.DAL.IgracDAO cd = new DAL.DAL.IgracDAO();
            Igraci = cd.getAll();
            d1.terminirajKonekciju();
            int broj = listBox1.SelectedIndex;
            foreach (Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Pom_Igraci;
            listBox1.SelectedIndex = broj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Igrac selektirani_igrac = (Igrac)(listBox1.SelectedItem);
            selektirani_igrac.DajPozicija = "SG";
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            selektirani_igrac = cd1.update(selektirani_igrac);
            DAL.DAL.IgracDAO cd = new DAL.DAL.IgracDAO();
            Igraci = cd.getAll();
            d1.terminirajKonekciju();
            int broj = listBox1.SelectedIndex;
            foreach (Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Igraci;
            listBox1.SelectedIndex = broj;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Igrac selektirani_igrac = (Igrac)(listBox1.SelectedItem);
            selektirani_igrac.DajPozicija = "SF";
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            selektirani_igrac = cd1.update(selektirani_igrac);
            DAL.DAL.IgracDAO cd = new DAL.DAL.IgracDAO();
            Igraci = cd.getAll();
            d1.terminirajKonekciju();
            int broj = listBox1.SelectedIndex;
            
            foreach (Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Igraci;
            listBox1.SelectedIndex = broj;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Igrac selektirani_igrac = (Igrac)(listBox1.SelectedItem);
            selektirani_igrac.DajPozicija = "PF";
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            selektirani_igrac = cd1.update(selektirani_igrac);
            DAL.DAL.IgracDAO cd = new DAL.DAL.IgracDAO();
            Igraci = cd.getAll();
            d1.terminirajKonekciju();
            int broj = listBox1.SelectedIndex;
            
            foreach (Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Igraci;
            listBox1.SelectedIndex = broj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Igrac selektirani_igrac = (Igrac)(listBox1.SelectedItem);
            selektirani_igrac.DajPozicija = "C";
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            selektirani_igrac = cd1.update(selektirani_igrac);
            DAL.DAL.IgracDAO cd = new DAL.DAL.IgracDAO();
            Igraci = cd.getAll();
            d1.terminirajKonekciju();
            int broj = listBox1.SelectedIndex;
            
            foreach (Igrac i in Igraci)
            {
                if (i.DajPozicija == "N/A")
                    Pom_Igraci.Add(i);
            }
            Igraci = Pom_Igraci;
            listBox1.DataSource = Igraci;
            listBox1.SelectedIndex = broj;
        }
    }
}
