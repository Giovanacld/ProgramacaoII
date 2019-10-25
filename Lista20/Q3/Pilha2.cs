using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Pilha2<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        public int Count()
        {
            return q1.Count;
        }
        public T Top()
        {
            T r = default(T);
            for (int i = 0; i < q1.Count - 1; i++)
            {
                if (i < q1.Count - 2) q2.Enqueue(q1.Dequeue());
                else
                {
                    r = q1.Dequeue();
                    q2.Enqueue(r);
                }
            }
            for (int i = 0; i < q2.Count - 1; i++)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return r;
        }
        public T Pop()
        {
            T r = default(T);
            for(int i = 0; i < q1.Count-1; i++)
            {
                if (i < q1.Count - 2) q2.Enqueue(q1.Dequeue());
                else
                {
                    r = q1.Dequeue();
                }
            }
            for (int i = 0; i < q2.Count - 1; i++)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return r;
        }
        public void Push(T obj)
        {
            q1.Enqueue(obj);
        }
    }
}
