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
    public partial class PregledSezona : Form
    {
        List<Igrac> Igraci = null;
        List<SezonskiPodaci> Sezone = null;
        Igrac selektirani_igrac = null;
        public PregledSezona()
        {
            InitializeComponent();
        }

        private void PregledSezona_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.sezone' table. You can move, or remove it, as needed.
            this.sezoneTableAdapter.Fill(this.mydbDataSet.sezone);
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            Igraci = cd1.getAll();
            d1.terminirajKonekciju();
            comboBox1.DataSource = Igraci;
            selektirani_igrac = (Igrac)(comboBox1.SelectedItem);
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.SezonskiPodaciDAO cd2 = new DAL.DAL.SezonskiPodaciDAO();
            Sezone = cd2.GetByPlayerID(selektirani_igrac.Daj_Igrac_ID);
            d1.terminirajKonekciju();
            //mydbDataSet.sezone.Clear();
         }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirani_igrac = (Igrac)(comboBox1.SelectedItem);
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.SezonskiPodaciDAO cd2 = new DAL.DAL.SezonskiPodaciDAO();
            Sezone = cd2.GetByPlayerID(selektirani_igrac.Daj_Igrac_ID);
            d1.terminirajKonekciju();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Sezone;
            /*SezonskiPodaci temp = Sezone[0];
            MessageBox.Show(Convert.ToString(temp.TrueShotPCT()));*/
        }

        private void b_TSP_Click(object sender, EventArgs e)
        {
            int broj=1;
            string TrueS = "";
            List<float> lista_TSP_sezone = new List<float>();
            Igrac i = (Igrac)(comboBox1.SelectedItem);
            foreach (SezonskiPodaci s in Sezone)
            {
                lista_TSP_sezone.Add(s.TrueShotPCT());
                TrueS += Convert.ToString(broj)+". "+Convert.ToString(s.TrueShotPCT())+ " % \n";
                broj++;
            }
            TrueS += "Što predstavlja prosjek od " + Convert.ToString(lista_TSP_sezone.Average()) + " % u dosadašnjoj karijeri \n";
            MessageBox.Show(i + " je za " + lista_TSP_sezone.Count() + " sezone/a u NBA ligi ostvario sljedeće TCP: \n" +TrueS);
        }

        private void EffSt_Click(object sender, EventArgs e)
        {
            int broj = 1;
            string TrueS = "";
            List<float> lista_TSP_sezone = new List<float>();
            Igrac i = (Igrac)(comboBox1.SelectedItem);
            foreach (SezonskiPodaci s in Sezone)
            {
                lista_TSP_sezone.Add(s.StandardEff());
                TrueS += Convert.ToString(broj) + ". " + Convert.ToString(s.StandardEff()) + "\n";
                broj++;
            }
            TrueS += "Što predstavlja prosjek od " + Convert.ToString(lista_TSP_sezone.Average()) + " u dosadašnjoj karijeri\n";
            MessageBox.Show(i + " je za " + lista_TSP_sezone.Count() + " sezone/a u NBA ligi ostvario sljedeće EFF:\n" + TrueS);
        }

        private void EC_Click(object sender, EventArgs e)
        {
            try
            {
                int broj = 1;
                string TrueS = "";
                List<float> lista_TSP_sezone = new List<float>();
                Igrac i = (Igrac)(comboBox1.SelectedItem);
                foreach (SezonskiPodaci s in Sezone)
                {
                    lista_TSP_sezone.Add(s.Economy());
                    TrueS += Convert.ToString(broj) + ". " + Convert.ToString(s.Economy()) + "\n";
                    broj++;
                }
                TrueS += "Što predstavlja prosjek od " + Convert.ToString(lista_TSP_sezone.Average()) + "u dosadašnjoj karijeri \n";
                MessageBox.Show(i + " je za " + lista_TSP_sezone.Count() + " sezone/a u NBA ligi ostvario sljedeće TCP: \n" + TrueS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(PER()));
        }
        public float PER()
        {
            try
            {
                float PER, uPER, factor, VOP, DRBP, zagrada1, zagrada2, zagrada3, tmafg, zagrada4, zagrada5, zagrada6, zagrada7, zagrada8, zagrada9, zagrada10, zagrada11, lgPace, tmPace;
                List<SezonskiPodaci> lista_ekipnih_podataka = null;
                List<SezonskiPodaci> Lista_igraca_unutar_ekipe = null;
                List<SezonskiPodaci> lista_sezona_igraca = null;
                List<SezonskiPodaci> prosjek_lige = null;
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.SezonskiPodaciDAO cd2 = new DAL.DAL.SezonskiPodaciDAO();
                lista_sezona_igraca = cd2.GetByPlayerID(selektirani_igrac.Daj_Igrac_ID);
                lista_ekipnih_podataka = cd2.GetByClubID(lista_sezona_igraca[0].DajTim_ID);
                prosjek_lige = cd2.GetByPlayerID(444);
                d1.terminirajKonekciju();
                int pomoc = lista_sezona_igraca.Count - 1;
                factor = (float)0.6666 - (float)((0.5 * prosjek_lige[0].DajAsist / prosjek_lige[0].DajSut_Pogodjeni)) / (2 * prosjek_lige[0].DajSut_Pogodjeni / prosjek_lige[0].DajSut_1_Poen_Pogodjeni);
                VOP = (float)((prosjek_lige[0].DajPoeni) / (prosjek_lige[0].DajSut_Pokusani - prosjek_lige[0].DajSkok_Napad + prosjek_lige[0].DajIzgubljena + 0.44 * prosjek_lige[0].DajSut_1_Poen_Pokusani));
                DRBP = (float)(prosjek_lige[0].DajSkok_Odbrana) / (prosjek_lige[0].DajSkok_Odbrana + prosjek_lige[0].DajSkok_Napad);
                tmafg = (float)lista_ekipnih_podataka[0].DajAsist / lista_ekipnih_podataka[0].DajSut_Pogodjeni;
                zagrada1 = (float)0.6666 * lista_sezona_igraca[pomoc].DajAsist;
                zagrada2 = (float)((2 - factor * tmafg) * lista_sezona_igraca[0].DajSut_Pogodjeni);
                zagrada3 = (float)(0.5 * lista_sezona_igraca[pomoc].DajSut_1_Poen_Pogodjeni * (2 - tmafg + 0.6666 * tmafg));
                zagrada4 = (float)(VOP * lista_sezona_igraca[0].DajIzgubljena);
                zagrada5 = (float)(VOP * DRBP * (lista_sezona_igraca[0].DajSut_Pokusani - lista_sezona_igraca[0].DajSut_Pogodjeni));
                zagrada6 = (float)(VOP * 0.44 * (0.44 + (0.56 * DRBP)) * (lista_sezona_igraca[0].DajSut_1_Poen_Pokusani - lista_sezona_igraca[0].DajSut_1_Poen_Pogodjeni));
                zagrada7 = (float)(VOP * (1 - DRBP) * (lista_sezona_igraca[0].DajSkok_Odbrana));
                zagrada8 = (float)(VOP * DRBP * lista_sezona_igraca[0].DajSkok_Napad);
                zagrada9 = (float)(VOP * lista_sezona_igraca[0].DajUkradena);
                zagrada10 = (float)(VOP * DRBP * lista_sezona_igraca[0].DajBlok);
                zagrada11 = (float)(lista_sezona_igraca[0].DajLicne_Greske * (prosjek_lige[0].DajSut_1_Poen_Pokusani / prosjek_lige[0].DajLicne_Greske - 0.44 * prosjek_lige[0].DajSut_1_Poen_Pokusani / prosjek_lige[0].DajLicne_Greske * VOP));
                uPER = (float)(lista_sezona_igraca[0].DajSut_3_Poena_Pogodjeni + zagrada1 + zagrada2 + zagrada3 - zagrada4 - zagrada5 - zagrada6 + zagrada7 + zagrada8 + zagrada9 + zagrada10 - zagrada11) / lista_sezona_igraca[0].DajBroj_Minuta;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.KlubDAO cd3 = new DAL.DAL.KlubDAO();
                lgPace = cd3.GetPace(31);
                tmPace = cd3.GetPace(lista_sezona_igraca[0].DajTim_ID);
                d1.terminirajKonekciju();
                PER = (float)(uPER * (lgPace / tmPace)) * 15;
                return PER;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
