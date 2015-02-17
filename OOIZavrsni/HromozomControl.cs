using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entiteti;

namespace OOIZavrsni
{
    public partial class HromozomControl : UserControl
    {
        private Hromozom h;
        private int bh;
        public HromozomControl(Hromozom ht,int broj_h)
        {
            h = ht;
            bh = broj_h;
            InitializeComponent();
        }

        private void HromozomControl_Load(object sender, EventArgs e)
        {
            l_broj_hromozoma.Text = ""+bh;
            l_fitness.Text = h.Daj_Fitness + "";
        }

        private void HromozomControl_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(h + "");
            System.Windows.Forms.Clipboard.SetText(h.Kod+" "+h.Daj_Fitness);
        }
    }
}
