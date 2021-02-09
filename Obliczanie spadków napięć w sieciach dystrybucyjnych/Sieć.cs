using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczanie_spadków_napięć_w_sieciach_dystrybucyjnych
{
    abstract class Sieć
    {
        protected double U; //napiecie na linii
        protected double I; //prad w linii
        protected double fi; //cos fi

        public Sieć(double I,double fi)
        {
            prad = I;
            przesuniecie = fi;
        }
        public abstract double ustalU
        {
            get;
            set;
        }
        public double prad
        {
            get
            {
                return I;
            }
            set
            {
                I = value;
            }
        }
        public double przesuniecie
        {
            get
            {
                return fi;
            }
            set
            {
                fi = value;
            }
        }
        public abstract void obliczU();
    }
}
