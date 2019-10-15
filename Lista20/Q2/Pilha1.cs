using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Pilha1<T>
    {
        private List<T> lista;
        public int Count()
        {
            return lista.Count;
        }
        public T Top()
        {
            return lista[0];
        }
        public T Pop(T r)
        {
            return lista.Remove(r);
        }

        public void Push(T a)
        {
            lista.Add(a);
        }
    }
}
