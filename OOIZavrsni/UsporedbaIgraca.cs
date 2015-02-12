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
    public partial class UsporedbaIgraca : Form
    {
        List<Igrac> Igraci1 = new List<Igrac>();
        List<Igrac> Igraci2 = new List<Igrac>();
        string[] PPG = new string[600];
        string fPPG = "PPG.txt";
        Igrac selektirani_igrac_lijevo = null;
        Igrac selektirani_igrac_desno = null;
        List<SezonskiPodaci> sz_lijevo = null;
        List<SezonskiPodaci> sz_desno = null;
        SezonskiPodaci trenutnaSezonaLijevo = new SezonskiPodaci();
        SezonskiPodaci trenutnaSezonaDesno = new SezonskiPodaci();
        public UsporedbaIgraca()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            PPG = System.IO.File.ReadAllLines(fPPG);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsporedbaIgraca_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd1 = new DAL.DAL.IgracDAO();
            Igraci1 = cd1.getAll();
            d1.terminirajKonekciju();
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.IgracDAO cd2 = new DAL.DAL.IgracDAO();
            Igraci2 = cd2.getAll();
            d1.terminirajKonekciju();
            comboBox1.DataSource = Igraci1;
            comboBox3.DataSource = Igraci2;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trenutnaSezonaLijevo.Nuliraj();
            sz_lijevo = null;
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.SezonskiPodaciDAO cd2 = new DAL.DAL.SezonskiPodaciDAO();
            selektirani_igrac_lijevo = Igraci1[comboBox1.SelectedIndex];
            sz_lijevo = cd2.GetByPlayerID(selektirani_igrac_lijevo.Daj_Igrac_ID);
            foreach (SezonskiPodaci s in sz_lijevo)
            {
                if (s.DajGodina_Sezone == comboBox2.SelectedItem.ToString())
                {
                    trenutnaSezonaLijevo.DajAsist += s.DajAsist;
                    trenutnaSezonaLijevo.DajBlok += s.DajBlok;
                    trenutnaSezonaLijevo.DajBroj_Minuta += s.DajBroj_Minuta;
                    trenutnaSezonaLijevo.DajBroj_Utakmica += s.DajBroj_Utakmica;
                    trenutnaSezonaLijevo.DajBroj_Utakmica_Starter += s.DajBroj_Utakmica_Starter;
                    trenutnaSezonaLijevo.DajGodina_Sezone = trenutnaSezonaLijevo.DajGodina_Sezone;
                    trenutnaSezonaLijevo.DajIgracID = s.DajIgracID;
                    trenutnaSezonaLijevo.DajIzgubljena += s.DajIzgubljena;
                    trenutnaSezonaLijevo.DajLicne_Greske += s.DajLicne_Greske;
                    trenutnaSezonaLijevo.DajPoeni += s.DajPoeni;
                    trenutnaSezonaLijevo.DajPoz = s.DajPoz;
                    trenutnaSezonaLijevo.DajSezonskiPodaci_ID = s.DajSezonskiPodaci_ID;
                    trenutnaSezonaLijevo.DajSkok_Napad += s.DajSkok_Napad;
                    trenutnaSezonaLijevo.DajSkok_Odbrana += s.DajSkok_Odbrana;
                    trenutnaSezonaLijevo.DajStarost = s.DajStarost;
                    trenutnaSezonaLijevo.DajSut_1_Poen_Pogodjeni += s.DajSut_1_Poen_Pogodjeni;
                    trenutnaSezonaLijevo.DajSut_1_Poen_Pokusani += s.DajSut_1_Poen_Pokusani;
                    trenutnaSezonaLijevo.DajSut_2_Poena_Pogodjeni += s.DajSut_2_Poena_Pogodjeni;
                    trenutnaSezonaLijevo.DajSut_2_Poena_Pokusani += s.DajSut_2_Poena_Pokusani;
                    trenutnaSezonaLijevo.DajSut_3_Poena_Pogodjeni += s.DajSut_3_Poena_Pogodjeni;
                    trenutnaSezonaLijevo.DajSut_3_Poena_Pokusani += s.DajSut_3_Poena_Pokusani;
                    trenutnaSezonaLijevo.DajSut_Pogodjeni += s.DajSut_Pogodjeni;
                    trenutnaSezonaLijevo.DajSut_Pokusani += s.DajSut_Pokusani;
                    trenutnaSezonaLijevo.DajTim_ID = s.DajTim_ID;
                    trenutnaSezonaLijevo.DajUkradena += s.DajUkradena;
                }
            }
            trenutnaSezonaLijevo.DajProcenat_Sut_1 = (float)(trenutnaSezonaLijevo.DajSut_1_Poen_Pogodjeni) / trenutnaSezonaLijevo.DajSut_1_Poen_Pokusani;
            trenutnaSezonaLijevo.DajProcenat_Sut_2 = (float)(trenutnaSezonaLijevo.DajSut_2_Poena_Pogodjeni) / trenutnaSezonaLijevo.DajSut_2_Poena_Pokusani;
            trenutnaSezonaLijevo.DajProcenat_Sut_3 = (float)(trenutnaSezonaLijevo.DajSut_3_Poena_Pogodjeni) / trenutnaSezonaLijevo.DajSut_3_Poena_Pokusani;
            trenutnaSezonaLijevo.DajProcenat_Sut_Sve = (float)(trenutnaSezonaLijevo.DajSut_Pogodjeni) / trenutnaSezonaLijevo.DajSut_Pokusani;
            pPTS1.Value = trenutnaSezonaLijevo.DajPoeni;
            pREB1.Value = trenutnaSezonaLijevo.DajSkok_Napad + trenutnaSezonaLijevo.DajSkok_Odbrana;
            pAST1.Value = trenutnaSezonaLijevo.DajAsist;
            pORB1.Value = trenutnaSezonaLijevo.DajSkok_Napad;
            pDRB1.Value = trenutnaSezonaLijevo.DajSkok_Odbrana;
            pBLK1.Value = trenutnaSezonaLijevo.DajBlok;
            pMIN1.Value = trenutnaSezonaLijevo.DajBroj_Minuta;
            if(trenutnaSezonaLijevo.DajSut_Pokusani==0)
                pFG1.Value = 0;
            else
                pFG1.Value = Convert.ToInt32(trenutnaSezonaLijevo.DajProcenat_Sut_Sve*100);
            if(trenutnaSezonaLijevo.DajSut_1_Poen_Pokusani==0)
                p1FG1.Value = 0;
            else
                p1FG1.Value = Convert.ToInt32(trenutnaSezonaLijevo.DajProcenat_Sut_1 * 100);

            if (trenutnaSezonaLijevo.DajSut_2_Poena_Pokusani == 0)
                p2FG1.Value = 0;
            else
                p2FG1.Value = Convert.ToInt32(trenutnaSezonaLijevo.DajProcenat_Sut_2 * 100);
            if (trenutnaSezonaLijevo.DajSut_3_Poena_Pokusani == 0)
                p3FG1.Value = 0;
            else
                p3FG1.Value = Convert.ToInt32(trenutnaSezonaLijevo.DajProcenat_Sut_3 * 100);
            if (trenutnaSezonaLijevo.DajBroj_Utakmica != 0)
            {
                pMPG1.Value = Convert.ToInt32((float)(trenutnaSezonaLijevo.DajBroj_Minuta) / trenutnaSezonaLijevo.DajBroj_Utakmica);
                pSvB1.Value = Convert.ToInt32((float)((trenutnaSezonaLijevo.DajBroj_Utakmica_Starter) / trenutnaSezonaLijevo.DajBroj_Utakmica) * 100);
                pFPG1.Value = Convert.ToInt32((float)(trenutnaSezonaLijevo.DajLicne_Greske) / trenutnaSezonaLijevo.DajBroj_Utakmica);
            }
            else
            {
                pMPG1.Value = 0;
                pSvB1.Value = 0;
                pFPG1.Value = 0;
            }
            pEFF1.Value = Convert.ToInt32(trenutnaSezonaLijevo.StandardEff());
            pTS1.Value = Convert.ToInt32(trenutnaSezonaLijevo.TrueShotPCT());
            pECO1.Value = Convert.ToInt32(trenutnaSezonaLijevo.Economy());
            lFG1.Text = pFG1.Value.ToString()+"%";
            l1FG1.Text = p1FG1.Value.ToString() + "%";
            l2FG1.Text = p2FG1.Value.ToString() + "%";
            l3FG1.Text = p3FG1.Value.ToString() + "%";
            lMPG1.Text = Convert.ToString(Math.Round((float)(trenutnaSezonaLijevo.DajBroj_Minuta) / trenutnaSezonaLijevo.DajBroj_Utakmica, 2));
            lSvB1.Text = Convert.ToString((Math.Round((float)(trenutnaSezonaLijevo.DajBroj_Utakmica_Starter) / trenutnaSezonaLijevo.DajBroj_Utakmica, 2)) * 100);
            lFPG1.Text = Convert.ToString((Math.Round((float)(trenutnaSezonaLijevo.DajLicne_Greske) / trenutnaSezonaLijevo.DajBroj_Utakmica, 2)));
            lPTS1.Text = pPTS1.Value.ToString();
            lAST1.Text = pAST1.Value.ToString();
            lORB1.Text = pORB1.Value.ToString();
            lDRB1.Text = pDRB1.Value.ToString();
            lBLK1.Text = pBLK1.Value.ToString();
            lREB1.Text = pREB1.Value.ToString();
            lMIN1.Text = pMIN1.Value.ToString();
            lEFF1.Text = Convert.ToString((Math.Round(trenutnaSezonaLijevo.StandardEff(), 2)));
            lTS1.Text = Convert.ToString((Math.Round(trenutnaSezonaLijevo.TrueShotPCT(), 2)));
            lECO1.Text = Convert.ToString((Math.Round((double)trenutnaSezonaLijevo.Economy(), 2)));
            int i = 0;
                foreach (string s in PPG)
                {
                    i++;
                    if (s.Contains(selektirani_igrac_lijevo.CistoIme()) && s.Contains(selektirani_igrac_lijevo.Prezime_Igraca))
                        lPPG1.Text = i + ".";
                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            trenutnaSezonaDesno.Nuliraj();
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "mydb", "root", "FCChelsea1");
            DAL.DAL.SezonskiPodaciDAO cd2 = new DAL.DAL.SezonskiPodaciDAO();
            selektirani_igrac_desno = Igraci2[comboBox3.SelectedIndex];
            sz_desno = cd2.GetByPlayerID(selektirani_igrac_desno.Daj_Igrac_ID);
            foreach (SezonskiPodaci s in sz_desno)
            {
                if (s.DajGodina_Sezone == comboBox2.SelectedItem.ToString())
                {
                    trenutnaSezonaDesno.DajAsist += s.DajAsist;
                    trenutnaSezonaDesno.DajBlok += s.DajBlok;
                    trenutnaSezonaDesno.DajBroj_Minuta += s.DajBroj_Minuta;
                    trenutnaSezonaDesno.DajBroj_Utakmica += s.DajBroj_Utakmica;
                    trenutnaSezonaDesno.DajBroj_Utakmica_Starter += s.DajBroj_Utakmica_Starter;
                    trenutnaSezonaDesno.DajGodina_Sezone = trenutnaSezonaDesno.DajGodina_Sezone;
                    trenutnaSezonaDesno.DajIgracID = s.DajIgracID;
                    trenutnaSezonaDesno.DajIzgubljena += s.DajIzgubljena;
                    trenutnaSezonaDesno.DajLicne_Greske += s.DajLicne_Greske;
                    trenutnaSezonaDesno.DajPoeni += s.DajPoeni;
                    trenutnaSezonaDesno.DajPoz = s.DajPoz;
                    trenutnaSezonaDesno.DajSezonskiPodaci_ID = s.DajSezonskiPodaci_ID;
                    trenutnaSezonaDesno.DajSkok_Napad += s.DajSkok_Napad;
                    trenutnaSezonaDesno.DajSkok_Odbrana += s.DajSkok_Odbrana;
                    trenutnaSezonaDesno.DajStarost = s.DajStarost;
                    trenutnaSezonaDesno.DajSut_1_Poen_Pogodjeni += s.DajSut_1_Poen_Pogodjeni;
                    trenutnaSezonaDesno.DajSut_1_Poen_Pokusani += s.DajSut_1_Poen_Pokusani;
                    trenutnaSezonaDesno.DajSut_2_Poena_Pogodjeni += s.DajSut_2_Poena_Pogodjeni;
                    trenutnaSezonaDesno.DajSut_2_Poena_Pokusani += s.DajSut_2_Poena_Pokusani;
                    trenutnaSezonaDesno.DajSut_3_Poena_Pogodjeni += s.DajSut_3_Poena_Pogodjeni;
                    trenutnaSezonaDesno.DajSut_3_Poena_Pokusani += s.DajSut_3_Poena_Pokusani;
                    trenutnaSezonaDesno.DajSut_Pogodjeni += s.DajSut_Pogodjeni;
                    trenutnaSezonaDesno.DajSut_Pokusani += s.DajSut_Pokusani;
                    trenutnaSezonaDesno.DajTim_ID = s.DajTim_ID;
                    trenutnaSezonaDesno.DajUkradena += s.DajUkradena;
                }
            }
            trenutnaSezonaDesno.DajProcenat_Sut_1 = (float)(trenutnaSezonaDesno.DajSut_1_Poen_Pogodjeni) / trenutnaSezonaDesno.DajSut_1_Poen_Pokusani;
            trenutnaSezonaDesno.DajProcenat_Sut_2 = (float)(trenutnaSezonaDesno.DajSut_2_Poena_Pogodjeni) / trenutnaSezonaDesno.DajSut_2_Poena_Pokusani;
            trenutnaSezonaDesno.DajProcenat_Sut_3 = (float)(trenutnaSezonaDesno.DajSut_3_Poena_Pogodjeni) / trenutnaSezonaDesno.DajSut_3_Poena_Pokusani;
            trenutnaSezonaDesno.DajProcenat_Sut_Sve = (float)(trenutnaSezonaDesno.DajSut_Pogodjeni) / trenutnaSezonaDesno.DajSut_Pokusani;
            pPTS2.Value = trenutnaSezonaDesno.DajPoeni;
            pREB2.Value = trenutnaSezonaDesno.DajSkok_Napad + trenutnaSezonaDesno.DajSkok_Odbrana;
            pAST2.Value = trenutnaSezonaDesno.DajAsist;
            pORB2.Value = trenutnaSezonaDesno.DajSkok_Napad;
            pDRB2.Value = trenutnaSezonaDesno.DajSkok_Odbrana;
            pBLK2.Value = trenutnaSezonaDesno.DajBlok;
            pMIN2.Value = trenutnaSezonaDesno.DajBroj_Minuta;
            if (trenutnaSezonaDesno.DajSut_Pokusani == 0)
                pFG2.Value = 0;
            else
                pFG2.Value = Convert.ToInt32(trenutnaSezonaDesno.DajProcenat_Sut_Sve * 100);
            if (trenutnaSezonaDesno.DajSut_1_Poen_Pokusani == 0)
                p1FG2.Value = 0;
            else
                p1FG2.Value = Convert.ToInt32(trenutnaSezonaDesno.DajProcenat_Sut_1 * 100);

            if (trenutnaSezonaDesno.DajSut_2_Poena_Pokusani == 0)
                p2FG2.Value = 0;
            else
                p2FG2.Value = Convert.ToInt32(trenutnaSezonaDesno.DajProcenat_Sut_2 * 100);
            if (trenutnaSezonaDesno.DajSut_3_Poena_Pokusani == 0)
                p3FG2.Value = 0;
            else
                p3FG2.Value = Convert.ToInt32(trenutnaSezonaDesno.DajProcenat_Sut_3 * 100);
            if (trenutnaSezonaDesno.DajBroj_Utakmica != 0)
            {
                pMPG2.Value = Convert.ToInt32((float)(trenutnaSezonaDesno.DajBroj_Minuta) / trenutnaSezonaDesno.DajBroj_Utakmica);
                pSvB2.Value = Convert.ToInt32((float)((trenutnaSezonaDesno.DajBroj_Utakmica_Starter) / trenutnaSezonaDesno.DajBroj_Utakmica) * 100);
                pFPG2.Value = Convert.ToInt32((float)(trenutnaSezonaDesno.DajLicne_Greske) / trenutnaSezonaDesno.DajBroj_Utakmica);
            }
            else
            {
                pMPG2.Value = 0;
                pSvB2.Value = 0;
                pFPG2.Value = 0;
            }
            pEFF2.Value = Convert.ToInt32(trenutnaSezonaDesno.StandardEff());
            pTS2.Value = Convert.ToInt32(trenutnaSezonaDesno.TrueShotPCT());
            pECO2.Value = Convert.ToInt32(trenutnaSezonaDesno.Economy());
            lFG2.Text = pFG2.Value.ToString() + "%";
            l1FG2.Text = p1FG2.Value.ToString() + "%";
            l2FG2.Text = p2FG2.Value.ToString() + "%";
            l3FG2.Text = p3FG2.Value.ToString() + "%";
            lMPG2.Text = Convert.ToString(Math.Round((float)(trenutnaSezonaDesno.DajBroj_Minuta) / trenutnaSezonaDesno.DajBroj_Utakmica,2));
            lSvB2.Text = Convert.ToString((Math.Round((float)(trenutnaSezonaDesno.DajBroj_Utakmica_Starter) / trenutnaSezonaDesno.DajBroj_Utakmica,2)) * 100);
            lFPG2.Text = Convert.ToString((Math.Round((float)(trenutnaSezonaDesno.DajLicne_Greske) / trenutnaSezonaDesno.DajBroj_Utakmica,2)));
            lPTS2.Text = pPTS2.Value.ToString();
            lAST2.Text = pAST2.Value.ToString();
            lORB2.Text = pORB2.Value.ToString();
            lDRB2.Text = pDRB2.Value.ToString();
            lBLK2.Text = pBLK2.Value.ToString();
            lREB2.Text = pREB2.Value.ToString();
            lMIN2.Text = pMIN2.Value.ToString();
            lEFF2.Text = Convert.ToString((Math.Round(trenutnaSezonaDesno.StandardEff(), 2)));
            lTS2.Text = Convert.ToString((Math.Round(trenutnaSezonaDesno.TrueShotPCT(), 2)));
            lECO2.Text = Convert.ToString((Math.Round((double)trenutnaSezonaDesno.Economy(), 2)));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
