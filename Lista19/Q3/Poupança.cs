using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Poupança : ContaCorrente
    {
        public Poupança(string t, string n) : base(t, n)
        {
        }
        public void Render(double j)
        {
            saldo += saldo * j;
        }
    }
}
