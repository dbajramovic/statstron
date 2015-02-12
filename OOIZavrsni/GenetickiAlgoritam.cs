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
    public partial class GenetickiAlgoritam : Form
    {
        private int _brojJedinki, _brojIteracija, _nivoElitizma, _SP;
        private List<Hromozom> _generacija = new List<Hromozom>();
        private Hromozom _najbolji = new Hromozom();
        private List<Igrac_GA> _lista_poc;
        private int broj_hromozoma = 0;
        private List<double> _lista_fitnessa = new List<double>();
        public GenetickiAlgoritam()
        {
            InitializeComponent();
        }

        private void btn_Kreni_Click(object sender, EventArgs e)
        {
            _najbolji = new Hromozom();
            chart1.Series["BestFitness"].Points.Clear();
            List<Hromozom> _nova_generacija = new List<Hromozom>();
            _brojIteracija = Convert.ToInt32(num_broj_iteracija.Value);
            _brojJedinki = Convert.ToInt32(num_broj_jedinki.Value);
            _nivoElitizma = Convert.ToInt32(num_nivo_elitizma.Value);
            System.Random j = new System.Random();
            double total_fitness = 0.0;
            _SP = Convert.ToInt32(num_SP.Value);
            //flp_hromozomi.Controls.Clear();
            for (int i = 0; i < _brojJedinki; i++)
            {
                 Hromozom h = new Hromozom();
                 h.Popuni(_lista_poc);
                 _generacija.Add(h);
                 h.racunajFitness(109.5, 103.0, 77.1, 51.1, 37.1);
                 _lista_fitnessa.Add(h.Daj_Fitness);
                 broj_hromozoma++;
                 //MessageBox.Show(""+_generacija[i]);
            }
            List<Hromozom> temp_lista_hrom = _generacija;
                while (_brojIteracija > 0)
                {

                    for (int i = 0; i < _generacija.Count; i++)
                    {
                        for (int k = 0; k < _generacija.Count; k++)
                        {
                            if (_generacija[k].Daj_Fitness < _generacija[i].Daj_Fitness)
                            {
                                Hromozom t = _generacija[k];
                                _generacija[k] = _generacija[i];
                                _generacija[i] = t;
                            }
                        }
                    }
                        foreach (Hromozom h in _generacija)
                        {
                            int a = j.Next(0, _brojJedinki - 1);
                            h.rekombinacija(_generacija[a]);
                            h.mutacija(_lista_poc);
                            h.racunajFitness(109.5, 103.0, 77.1, 51.1, 37.1);
                            total_fitness += h.Daj_Fitness;
                        }
                        for (int i = 0; i < _nivoElitizma; i++)
                            _nova_generacija.Add(_generacija[i]);
                        List<double> lista_vjerovatnoce = new List<double>();
                        double suma = 0;
                        foreach (Hromozom h in _generacija)
                        {
                            suma += h.Daj_Fitness / total_fitness;
                            lista_vjerovatnoce.Add(suma);
                        }
                            for (int i = 0; i < _generacija.Count - _nivoElitizma; i++)
                            {
                                Hromozom hrom = null;
                                double rand = j.NextDouble();
                                int k = 0;
                                while (lista_vjerovatnoce[k] < rand)
                                {
                                    k++;
                                    if (k == lista_vjerovatnoce.Count)
                                    {
                                        k--;
                                        break;
                                    }
                                }
                                hrom = _generacija[k];
                                _nova_generacija.Add(hrom);
                            }
                        _generacija.Clear();
                        foreach (Hromozom h in _nova_generacija)
                            _generacija.Add(h);
                        for (int i = 0; i < _generacija.Count; i++)
                        {
                            for (int k = 0; k < _generacija.Count; k++)
                            {
                                if (_generacija[k].Daj_Fitness < _generacija[i].Daj_Fitness)
                                {
                                    Hromozom t = _generacija[k];
                                    _generacija[k] = _generacija[i];
                                    _generacija[i] = t;
                                }
                            }
                        }
                        if (_najbolji.Daj_Fitness < _generacija[0].Daj_Fitness)
                        {
                            //MessageBox.Show("Najbolji:" + _najbolji.Daj_Fitness + " G1:" + _generacija[0].Daj_Fitness);
                            _najbolji.Lista_igraca_hromozom = _generacija[0].Lista_igraca_hromozom;
                            _najbolji.racunajFitness(109.5, 103.0, 77.1, 51.1, 37.1);
                            _najbolji.RegenerisiKod();
                            //MessageBox.Show("POSLIJE: Najbolji:" + _najbolji.Daj_Fitness + " G1:" + _generacija[0].Daj_Fitness);
                        }
                        _nova_generacija.Clear();
                        total_fitness = 0;
                        _brojIteracija--;
                        chart1.Series["BestFitness"].Points.AddXY(Convert.ToInt32(num_broj_iteracija.Value) - _brojIteracija,_najbolji.Daj_Fitness);
                        progressBar1.Maximum = Convert.ToInt32(num_broj_iteracija.Value);
                        progressBar1.Value = Convert.ToInt32(num_broj_iteracija.Value) - _brojIteracija ;
                }
                flp_top.Controls.Clear();
                HromozomControl hc = new HromozomControl(_najbolji, 1);
                flp_top.Controls.Add(hc);
                _generacija.Clear();
                _nova_generacija.Clear();
                _lista_fitnessa.Clear();
        }		


        private void GenetickiAlgoritam_Load(object sender, EventArgs e)
        {
            DAL.DAL d1 = DAL.DAL.Instanca;
            d1.kreirajKonekciju("localhost", "ooi", "root", "FCChelsea1");
            DAL.DAL.Igrac_GADAO cd1 = new DAL.DAL.Igrac_GADAO();
            _lista_poc = cd1.getAll();
            d1.terminirajKonekciju();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
