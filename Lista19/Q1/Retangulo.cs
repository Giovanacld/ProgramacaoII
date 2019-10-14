using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Retangulo
    {
        private double b, h;
        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double GetB() { return b; }
        public double GetH() { return h; }
        public double CalqA()
        { return h * b; }
        public double CalcD()
        { return Math.Sqrt(b * b + h * h); }
        public override string ToString()
        {
            return ($"base: {b} -- altura: {h} -- area: {CalqA()} -- diagonal: {CalcD()}");
        }
    }
}
