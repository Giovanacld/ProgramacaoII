using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Frete
    {
        private double distancia, peso;
        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        public virtual decimal CalcFrete()
        {
            return 0.01m * (decimal)(peso * distancia);
        }
        public override string ToString()
        {
            return $"{distancia} {peso} {CalcFrete()}";
        }
    }
}
