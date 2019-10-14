using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();
        public void SetNum(int num) { this.num = num; }
        public string Binario()
        {
            pilha.Clear();
            int d = num;
            while (d != 0) { int r = d % 2; pilha.Push(r); d = d / 2; }
            string b = "";
            while (pilha.Count != 0) b = b + pilha.Pop();
            return b;
        }
    }
}
