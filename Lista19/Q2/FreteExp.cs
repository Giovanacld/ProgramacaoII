using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class FreteExp : Frete
    {
        private decimal seguro;
        public FreteExp(double d, double p, decimal s) : base(d, p)
        {
            seguro = s;
        }
        public override decimal CalcFrete()
        {
            return (2 * base.CalcFrete()) + (0.01m * seguro);
        }
        public override string ToString()
        {
            return $"{CalcFrete()} {seguro}";
        }
    }
}
