using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo(5, 4);
            Console.WriteLine(r.ToString());
            Quadrado q = new Quadrado(6);
            Console.WriteLine(q.ToString());
        }
    }
}
