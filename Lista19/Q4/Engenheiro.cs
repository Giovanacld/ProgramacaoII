using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Engenheiro : Funcionario
    {
        private string crea;
        public Engenheiro(string n, string e, string f, string c) : base(n, e, f)
        {
            crea = c;
        }
        public void SetCrea(string c)
        {
            if (c != "") crea = c;
        }
        public string GetCrea()
        {
            return crea;
        }
        public override string ToString()
        {
            return $"{crea}";
        }
    }
}
