using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public string Matrícula { get; set; }
        public int CompareTo(object obj)
        {
            Aluno outro = obj as Aluno;
            return this.Nome.CompareTo(outro.Nome);
        }

    }
}
