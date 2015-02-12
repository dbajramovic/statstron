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
    public partial class UnosPodatakaGA : Form
    {
        private List<Igrac_GA> lista_igraca = new List<Igrac_GA>(0);
        Igrac_GA selektirani_igrac = null;
        public UnosPodatakaGA()
        {
            InitializeComponent();
        }

        private void UnosPodatakaGA_Load(object sender, EventArgs e)
        {
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "ooi", "root", "FCChelsea1");
            DAL.DAL.Igrac_GADAO cd1 = new DAL.DAL.Igrac_GADAO();
            lista_igraca = cd1.getAll();
            d1.terminirajKonekciju();
            comboBox1.DataSource = lista_igraca;
            selektirani_igrac = (Igrac_GA)(comboBox1.SelectedItem);
            Osvjezi();
        }
        private void Osvjezi()
        {
            num_OffRTG.Value = Convert.ToDecimal(selektirani_igrac.Daj_OffRTG);
            num_DefRTG.Value = Convert.ToDecimal(selektirani_igrac.Daj_DefRTG);
            num_1PMade.Value = Convert.ToDecimal(selektirani_igrac.Daj_1PMade);
            num_2PMade.Value = Convert.ToDecimal(selektirani_igrac.Daj_2PMade);
            num_3PMade.Value = Convert.ToDecimal(selektirani_igrac.Daj_3PMade);
            num_1PShot.Value = Convert.ToDecimal(selektirani_igrac.Daj_1PShot);
            num_2PShot.Value = Convert.ToDecimal(selektirani_igrac.Daj_2PShot);
            num_3PShot.Value = Convert.ToDecimal(selektirani_igrac.Daj_3PShot);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirani_igrac = (Igrac_GA)(comboBox1.SelectedItem);
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                selektirani_igrac.Daj_1PMade = Convert.ToInt32(num_1PMade.Value);
                selektirani_igrac.Daj_2PMade = Convert.ToInt32(num_2PMade.Value);
                selektirani_igrac.Daj_3PMade = Convert.ToInt32(num_3PMade.Value);
                selektirani_igrac.Daj_1PShot = Convert.ToInt32(num_1PShot.Value);
                selektirani_igrac.Daj_2PShot = Convert.ToInt32(num_2PShot.Value);
                selektirani_igrac.Daj_3PShot = Convert.ToInt32(num_3PShot.Value);
                selektirani_igrac.Daj_DefRTG = Convert.ToDouble(num_DefRTG.Value);
                selektirani_igrac.Daj_OffRTG = Convert.ToDouble(num_OffRTG.Value);
                MessageBox.Show(selektirani_igrac.ToString()+" "+selektirani_igrac.Daj_OffRTG);
                DAL.DAL d1 = DAL.DAL.Instanca;
                d1.kreirajKonekciju("localhost", "ooi", "root", "FCChelsea1");
                DAL.DAL.Igrac_GADAO cd1 = new DAL.DAL.Igrac_GADAO();
                Igrac_GA temp = cd1.update(selektirani_igrac);
                d1.terminirajKonekciju();
                MessageBox.Show("DODAN!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
