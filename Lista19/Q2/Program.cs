using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Frete f = new Frete(100, 20);
            Console.WriteLine(f.ToString());
            FreteExp fe = new FreteExp(2);
            Console.WriteLine(fe.ToString());
        }
    }
}
