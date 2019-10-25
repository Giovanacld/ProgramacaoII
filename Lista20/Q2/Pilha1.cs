using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Pilha1<T>
    {
        private List<T> lista = new List<T>();
        public int Count()
        {
            return lista.Count;
        }
        public T Top()
        {
            return lista[0];
        }
        public T Pop()
        {
            T b = lista[lista.Count() - 1];
            lista.RemoveAt(lista.Count() - 1);
            return b;
        }

        public void Push(T a)
        {
            lista.Add(a);
        }
    }
}
