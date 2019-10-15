using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Pilhas2<T>
    {
        private Queue<T> q1, q2;
        public int Count()
        {
            return q1.Count;
        }
        public T Top()
        {
            return q1.Peek;
        }
        public T Pop()
        {
            return q1.Dequeue;
        }
        public void Push(T obj)
        {
            q1.Enqueue(obj);
        }
    }
