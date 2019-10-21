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
            Teste t = new Teste();
            try
            {
                Console.WriteLine(t.Metodo1(int.Parse(Console.ReadLine())));
            }
            catch (Erro n)
            {
                Console.WriteLine("Número inválido");
            }
            Console.ReadKey();
        }
    }
}
