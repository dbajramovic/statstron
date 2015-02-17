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
    public partial class TestirajFitness : Form
    {
        private Hromozom h;
        private List<Igrac_GA> lista_igraca1 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca2 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca3 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca4 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca5 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca6 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca7 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca8 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca9 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca10 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca11 = new List<Igrac_GA>();
        private List<Igrac_GA> lista_igraca12 = new List<Igrac_GA>();
        public TestirajFitness()
        {
            InitializeComponent();
        }

        private void TestirajFitness_Load(object sender, EventArgs e)
        {
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "ooi", "root", "FCChelsea1");
            DAL.DAL.Igrac_GADAO cd1 = new DAL.DAL.Igrac_GADAO();
            lista_igraca1 = cd1.getAll();
            lista_igraca2 = cd1.getAll();
            lista_igraca3 = cd1.getAll();
            lista_igraca4 = cd1.getAll();
            lista_igraca5 = cd1.getAll();
            lista_igraca6 = cd1.getAll();
            lista_igraca7 = cd1.getAll();
            lista_igraca8 = cd1.getAll();
            lista_igraca9 = cd1.getAll();
            lista_igraca10 = cd1.getAll();
            lista_igraca11 = cd1.getAll();
            lista_igraca12 = cd1.getAll();
            d1.terminirajKonekciju();
            comboBox1.DataSource = lista_igraca1;
            comboBox2.DataSource = lista_igraca2;
            comboBox3.DataSource = lista_igraca3;
            comboBox4.DataSource = lista_igraca4;
            comboBox5.DataSource = lista_igraca5;
            comboBox6.DataSource = lista_igraca6;
            comboBox7.DataSource = lista_igraca7;
            comboBox8.DataSource = lista_igraca8;
            comboBox9.DataSource = lista_igraca9;
            comboBox10.DataSource = lista_igraca10;
            comboBox11.DataSource = lista_igraca11;
            comboBox12.DataSource = lista_igraca12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                h = new Hromozom();
                h.dodajIgraca((Igrac_GA)(comboBox1.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox2.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox3.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox4.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox5.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox6.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox7.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox8.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox9.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox10.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox11.SelectedItem));
                h.dodajIgraca((Igrac_GA)(comboBox12.SelectedItem));
                h.racunajFitness(109.5, 103.0, 77.1, 51.1, 37.1);
                h.RegenerisiKod();
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(new HromozomControl(h, 1));
            
        }
    }
}
