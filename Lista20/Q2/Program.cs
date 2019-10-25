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
            Pilha1<int> l = new Pilha1<int>();
            l.Push(1);
            l.Push(6);
            l.Push(8);
            l.Push(55);
            l.Top();
            l.Count();
            Console.WriteLine(l.Pop());
            Console.ReadKey();


        }
    }
}
