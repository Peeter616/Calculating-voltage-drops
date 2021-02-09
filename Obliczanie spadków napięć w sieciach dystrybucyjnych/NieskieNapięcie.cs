using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obliczanie_spadków_napięć_w_sieciach_dystrybucyjnych
{
    class NieskieNapięcie : Sieć
    {
        Kabel kab;
        public NieskieNapięcie(double I, double fi, double R0, double X0, double l = 50) : base(I, fi)
        {
            kab = new Kabel(R0, X0, l);
            obliczU();
        }

        public override double ustalU
        {
            get
            {
                return U;
            }
            set
            {
                if (value >= 230)
                {
                    MessageBox.Show("Spadek napięcia osiągnął napięcie pracy linii. Ustalone zostaną parametry domyślne.");
                }
                else
                {
                    U = value;
                }
            }
        }
        public double Rl //pobieranie rezystancji linii
        {
            get { return kab.Rl; }
        }

        public double Xl //pobieranie reaktancji linii
        {
            get { return kab.Xl; }
        }

        double funkcjaU(double i)
        {
            return Math.Sqrt(3) * prad * (kab.Rzero * i * Math.Cos(przesuniecie * Math.PI / 180) + kab.Xzero * i * Math.Cos(przesuniecie * Math.PI / 180));
        }

        public void Rysuj(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;//wykres liniowy
            Wyczyść(chart);
            for (double i = 0; i < kab.L; i += 0.001)
                chart.Series[0].Points.AddXY(i, funkcjaU(i));//rysowanie wykresu
        }

        public override void obliczU()
        {
            ustalU = Math.Sqrt(3) * prad * (kab.Rl * przesuniecie + kab.Xl * przesuniecie);
        }

        public void Wyczyść(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].Points.Clear();//czyszczenie wykresu
        }
    }
}
