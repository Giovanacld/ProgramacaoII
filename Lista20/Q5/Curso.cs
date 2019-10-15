using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Curso : Turma
    {
        private string descricao;
        private List<Turma> turmas;
        public Curso(string d)
        { descricao = d;  }
        public void AdicionarTurmas(Turma t)
        { turmas.Add(t); }
        public Turma[] ListarTurmas()
        {
            Turma[] ordenados = turmas.ToArray();
            Array.Sort(ordenados);
            return ordenados;
        }
    }
}
