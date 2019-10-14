using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();
        private int k;
        public void Inserir(Funcionario f)
        {
            funcs[k++] = f;
        }
        public List<Funcionario> Funcionarios()
        {
            return funcs;
        }
        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> eng = new List<Engenheiro>();
            foreach (Funcionario k in funcs) if (k is Engenheiro) eng.Add(k);
            return eng;
        }
        public List<Motorista> Motoristas()
        {
            List<Motorista> mot = new List<Motorista>();
            foreach (Funcionario k in funcs) if (k is Motorista) mot.Add(k);
            return mot;
        }
    }
}
