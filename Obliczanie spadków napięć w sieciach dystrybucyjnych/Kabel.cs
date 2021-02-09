using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczanie_spadków_napięć_w_sieciach_dystrybucyjnych
{
    class Kabel
    {

        double X0;
        double R0;
        double l;
        double RL;
        double XL;

        public Kabel(double l = 50)//konstruktor z możliwościa deklarowania l z domyślną długościa
        {
            Rzero = R0 = 100;//odgórna wartość rezystancji
            Xzero = X0 = 100;//odgórna wartość reaktancji
            this.l = l;//możliwośc deklaracji długości jedynie w konstruktorze
            RL = l * 100;
            XL = l * 100;
        }

        public Kabel(double R0, double X0, double l = 50)//konstruktor z możliwościa deklarowania R0, X0 i l z domyślną długościa
        {
            Rzero = R0;
            Xzero = X0;
            this.l = l;//możliwośc deklaracji długości jedynie w konstruktorze
            RL = obliczRL(R0);
            XL = obliczXL(X0);
        }

        public double Rzero
        {
            get { return R0; }
            set { R0 = value; }
        }

        public double Xzero
        {
            get { return X0; }
            set { X0 = value; }
        }

        public double L //pobieranie długości kabla
        {
            get { return l; }
        }

        public double Rl //pobieranie rezystancji linii
        {
            get { return RL; }
        }

        public double Xl //pobieranie reaktancji linii
        {
            get { return XL; }
        }

        public double obliczRL(double R0)
        {
            return R0 * L;//oblicznie rezystancji linii
        }

        public double obliczXL(double X0)
        {
            return X0 * L;//oblicznie reaktancji linii
        }

    }
}