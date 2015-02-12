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
    public partial class UnosIgraca : Form
    {
        public UnosIgraca()
        {
            InitializeComponent();
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Exception n = new Exception();
                Igrac novi_igrac = new Igrac(t_ime.Text, t_prezime.Text);
                if (t_ime.Text == "" || t_prezime.Text == "") throw n;
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
                novi_igrac.Daj_Igrac_ID = Convert.ToInt32(cd1.create(novi_igrac));
                MessageBox.Show("Igrač uspiješno dodan sa ID-om:" + novi_igrac.Daj_Igrac_ID);
                d1.terminirajKonekciju();
            }
            catch (Exception n)
            {
                MessageBox.Show(Convert.ToString(n));
            }
        }
    }
}
