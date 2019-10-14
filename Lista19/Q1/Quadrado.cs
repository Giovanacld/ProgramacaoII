using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Quadrado : Retangulo
    {
        public Quadrado(double l) : base(l, l) { }
        public override string ToString()
        {
            return $"lado: {base.GetB()} -- area: {base.CalqA()} -- diagonal: {base.CalcD()}";
        }
    }
}
