using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l) : base(t, n)
        {
            limite = l;
        }
        public override bool Sacar(double v)
        {
            if (v > limite) return false;
            else return true;
        }
    }
}
