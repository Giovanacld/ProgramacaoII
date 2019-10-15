using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c = new ContaCorrente("Gio", "666");
            c.Depositar(500);
            c.Sacar(20);
            Console.WriteLine(c.RetornarSaldo);
            Console.WriteLine(c.ToString);
        }
    }
}
