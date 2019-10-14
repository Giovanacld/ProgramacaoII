using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        public static void Main(string[] args)
        {
          Conversor c = new Conversor();
          c.SetNum(245);
          Console.WriteLine(c.Binario());
        }
    }
}

