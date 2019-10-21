using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Teste
    {
        public int Metodo1(int valor)
        {
            if (valor < 0) throw new Erro();
            return valor;
        }
    }
}
