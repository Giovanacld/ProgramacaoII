using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Retangulo
    {
        private double b, h;
        public void SetB(double b)
        {
            if (b < 0) throw new ArgumentOutOfRangeException();
            this.b = b;
        }
        public void SetH(double h)
        {
            if (h < 0) throw new ArgumentOutOfRangeException();
            this.h = h;
        }
        public double CalcA()
        { return h * b; }
    }
}

