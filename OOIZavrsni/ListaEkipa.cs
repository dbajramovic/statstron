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
    public partial class ListaEkipa : Form
    {
        List<Klub> Klubi = new List<Klub>();
        List<Klub> templista = new List<Klub>();
        public ListaEkipa()
        {
            InitializeComponent();
        }

        private void ListaEkipa_Load(object sender, EventArgs e)
        {
            try
            {
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.KlubDAO cd1 = new DAL.DAL.KlubDAO();
                Klubi = cd1.getAll();
                d1.terminirajKonekciju();
                listBox1.DataSource = Klubi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            templista.Clear();
            foreach (Klub i in Klubi)
            {
                String a = i.Ime_KLuba  + " " + i.grad_Kluba;
                if (a.Contains(textBox1.Text))
                    templista.Add(i);
            }
            listBox1.DataSource = null;
            listBox1.DataSource = templista;
        }
    }
}
