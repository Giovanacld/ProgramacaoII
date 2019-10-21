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
            Retangulo r = new Retangulo();
            try
            {
                r.SetB(double.Parse(Console.ReadLine()));
                r.SetH(double.Parse(Console.ReadLine()));
                Console.WriteLine(r.CalcA());
            }
            catch (ArgumentOutOfRangeException erro)
            {
                Console.WriteLine("Número inválido");
            }
            Console.ReadKey();
        }
    }
}
