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
    public partial class FileSezona : Form
    {
        List<Igrac> Igraci = new List<Igrac>();
        List<Klub> Klubovi = new List<Klub>();
        List<SezonskiPodaci> lista_za_upis = new List<SezonskiPodaci>();
        public FileSezona()
        {
            InitializeComponent();
        }

        private void FileSezona_Load(object sender, EventArgs e)
        {
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            Igraci = cd1.getAll();
            DAL.DAL.KlubDAO cd2 = new DAL.DAL.KlubDAO();
            Klubovi = cd2.getAll();
            d1.terminirajKonekciju();
            comboBox1.DataSource = Igraci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Igrac temp1 = (Igrac)(comboBox1.SelectedItem);
            string ime = temp1.Ime_Igraca;
            string prezime = temp1.Prezime_Igraca;
            openFileDialog1.FileName = String.Join("",prezime,ime) +".txt";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string linija = "";
            int broj = 0,indeks=1;
            bool ide = true;
            lista_za_upis.Clear();
            richTextBox1.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (ide)
                    {
                        float PCT_Sve = 0, ThreePCT = 0, TwoPCT = 0, FreePCT = 0;
                        string godina_sezone,baci, Tim="N/A", Pozicija="N/A", tempPCT_Sve, tempThreePCT, tempTwoPCT, tempFreePCT;
                        int TimID =0,starost=0, Broj_Utakmica, Broj_Utakmica_Starter=0, Broj_Minuta, Pogodjeni_Sve, Pokusani_Sve, ThreeMade, ThreeAtt, TwoMade, TwoAtt, FreeMade,FreeAtt,ORB,DRB,TRB,AST,STL,BLK,TO,FLS,PTS;
                        linija = sr.ReadLine();
                        if (linija == null) ide = false;
                        if (!checkBox1.Checked)
                        {
                            godina_sezone = linija.Split(',')[0];
                            starost = Convert.ToInt32(linija.Split(',')[1]);
                            Tim = linija.Split(',')[2];
                            baci = linija.Split(',')[3];
                            Pozicija = linija.Split(',')[4];
                            Broj_Utakmica = Convert.ToInt32(linija.Split(',')[5]);
                            Broj_Utakmica_Starter = Convert.ToInt32(linija.Split(',')[6]);
                            Broj_Minuta = Convert.ToInt32(linija.Split(',')[7]);
                            Pogodjeni_Sve = Convert.ToInt32(linija.Split(',')[8]);
                            Pokusani_Sve = Convert.ToInt32(linija.Split(',')[9]);
                            tempPCT_Sve = linija.Split(',')[10];
                            ThreeMade = Convert.ToInt32(linija.Split(',')[11]);
                            ThreeAtt = Convert.ToInt32(linija.Split(',')[12]);
                            tempThreePCT = linija.Split(',')[13];
                            TwoMade = Convert.ToInt32(linija.Split(',')[14]);
                            TwoAtt = Convert.ToInt32(linija.Split(',')[15]);
                            tempTwoPCT = linija.Split(',')[16];
                            FreeMade = Convert.ToInt32(linija.Split(',')[17]);
                            FreeAtt = Convert.ToInt32(linija.Split(',')[18]);
                            tempFreePCT = linija.Split(',')[19];
                            ORB = Convert.ToInt32(linija.Split(',')[20]);
                            DRB = Convert.ToInt32(linija.Split(',')[21]);
                            TRB = Convert.ToInt32(linija.Split(',')[22]);
                            AST = Convert.ToInt32(linija.Split(',')[23]);
                            STL = Convert.ToInt32(linija.Split(',')[24]);
                            BLK = Convert.ToInt32(linija.Split(',')[25]);
                            TO = Convert.ToInt32(linija.Split(',')[26]);
                            FLS = Convert.ToInt32(linija.Split(',')[27]);
                            PTS = Convert.ToInt32(linija.Split(',')[28]);
                        }
                        else
                        {
                            godina_sezone = linija.Split(',')[0];
                            baci = linija.Split(',')[1];
                            Broj_Utakmica = Convert.ToInt32(linija.Split(',')[2]);
                            Broj_Minuta = Convert.ToInt32(linija.Split(',')[3]);
                            Pogodjeni_Sve = Convert.ToInt32(linija.Split(',')[4]);
                            Pokusani_Sve = Convert.ToInt32(linija.Split(',')[5]);
                            tempPCT_Sve = linija.Split(',')[6];
                            ThreeMade = Convert.ToInt32(linija.Split(',')[7]);
                            ThreeAtt = Convert.ToInt32(linija.Split(',')[8]);
                            tempThreePCT = linija.Split(',')[9];
                            TwoMade = Convert.ToInt32(linija.Split(',')[10]);
                            TwoAtt = Convert.ToInt32(linija.Split(',')[11]);
                            tempTwoPCT = linija.Split(',')[12];
                            FreeMade = Convert.ToInt32(linija.Split(',')[13]);
                            FreeAtt = Convert.ToInt32(linija.Split(',')[14]);
                            tempFreePCT = linija.Split(',')[15];
                            ORB = Convert.ToInt32(linija.Split(',')[16]);
                            DRB = Convert.ToInt32(linija.Split(',')[17]);
                            TRB = Convert.ToInt32(linija.Split(',')[18]);
                            AST = Convert.ToInt32(linija.Split(',')[19]);
                            STL = Convert.ToInt32(linija.Split(',')[20]);
                            BLK = Convert.ToInt32(linija.Split(',')[21]);
                            TO = Convert.ToInt32(linija.Split(',')[22]);
                            FLS = Convert.ToInt32(linija.Split(',')[23]);
                            PTS = Convert.ToInt32(linija.Split(',')[24]);
                            baci = linija.Split(',')[25];
                        }
                        if(Pogodjeni_Sve!=0 || Pokusani_Sve!=0)
                        PCT_Sve = ((float)Pogodjeni_Sve / Pokusani_Sve)*100;
                        if(ThreeAtt!=0 || ThreeMade !=0)
                        ThreePCT = ((float)ThreeMade/ThreeAtt)*100;
                        if(TwoAtt!=0 || ThreeMade !=0)
                        TwoPCT = ((float)TwoMade / TwoAtt)*100;
                        if(FreeAtt!=0 || FreeMade!=0)
                        FreePCT = ((float)FreeMade / FreeAtt)*100;
                        broj++;
                        foreach (Klub k in Klubovi)
                        {
                            if (k.DajSkracenica == Tim)
                                TimID = k.DajIDKluba;
                        }
                        if (!checkBox1.Checked)
                        {
                            SezonskiPodaci f = new SezonskiPodaci(godina_sezone,starost, TimID, Pozicija, Broj_Utakmica, Broj_Utakmica_Starter, Broj_Minuta, Pokusani_Sve, Pogodjeni_Sve, ThreeAtt, ThreeMade, TwoAtt, TwoMade, FreeAtt, FreeMade, ORB, DRB, AST, BLK, STL, TO, FLS, PTS, comboBox1.SelectedIndex + 1);
                            f.DajProcenat_Sut_Sve = PCT_Sve;
                            f.DajProcenat_Sut_3 = ThreePCT;
                            f.DajProcenat_Sut_2 = TwoPCT;
                            f.DajProcenat_Sut_1 = FreePCT;
                            lista_za_upis.Add(f);
                        }
                        else
                        {
                            SezonskiPodaci f = new SezonskiPodaci("2013-14",0, 31, "N/A", Broj_Utakmica, Broj_Utakmica, Broj_Minuta, Pokusani_Sve, Pogodjeni_Sve, ThreeAtt, ThreeMade, TwoAtt, TwoMade, FreeAtt, FreeMade, ORB, DRB, AST, BLK, STL, TO, FLS, PTS,444);
                            f.DajProcenat_Sut_Sve = PCT_Sve;
                            f.DajProcenat_Sut_3 = ThreePCT;
                            f.DajProcenat_Sut_2 = TwoPCT;
                            f.DajProcenat_Sut_1 = FreePCT;
                            lista_za_upis.Add(f);
                            indeks++;
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            foreach (SezonskiPodaci i in lista_za_upis)
            {
                richTextBox1.Text += Convert.ToString(indeks)+ i + " \n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Exception n = new Exception();
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
                DAL.DAL.SezonskiPodaciDAO cd1 = new DAL.DAL.SezonskiPodaciDAO();
                foreach (SezonskiPodaci i in lista_za_upis)
                {
                    i.DajSezonskiPodaci_ID = Convert.ToInt32(cd1.create(i));
                }
                MessageBox.Show("Sezone uspijesno dodane!");
                d1.terminirajKonekciju();
            }
            catch (Exception n)
            {
                MessageBox.Show(Convert.ToString(n));
            }
        }
    }
}
