using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Turma : Aluno
    {
        private string semestre, disciplina;
       
        private List<Aluno> alunos;
        private int n;
        public int NumALunos { get { return alunos.Count; } }
        public Turma(string s, string d)
        {
            semestre = s;
            disciplina = d;
        }
        public void AdicionarAluno(Aluno a)
        { alunos.Add(a); }
        public int CompareTo(object obj)
        {
            Turma outro = obj as Turma;
            if (this.disciplina == outro.disciplina) return this.semestre.CompareTo(outro.semestre);
            return this.disciplina.CompareTo(outro.disciplina);) 
        }
        public Aluno[] ListarAlunos()
        {
            Aluno[] ordenados = alunos.ToArray();
            Array.Sort(ordenados);
            return ordenados;
        }
    }
}
