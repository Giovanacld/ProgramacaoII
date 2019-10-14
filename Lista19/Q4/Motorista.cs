using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Motorista : Funcionario
    {
        private string cnh;
        public Motorista(string n, string e, string f, string c) : base (n, e, f)
        {
            cnh = c;
        }
        public void SetCnh(string c)
        {
            if (c != "") cnh = c;
        }
        public string GetCnh()
        {
            return cnh;
        }
        public override string ToString()
        {
            return $"{cnh}";
        }
    }
}
