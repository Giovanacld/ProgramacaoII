using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Loja : Veiculo
    {
        private string nome;
        private List<Veiculo> veiculos;
        public Loja(string n, string p, string f, string m, int a, decimal pr) : base (p,f,m,a,pr)
        {
            nome = n;
        }
        public void Inserir(Veiculo c)
        {
            veiculos.Add(c);
        }
        public void Excluir(Veiculo c)
        {
            veiculos.Remove(c);
        }
        public List<Veiculo> ListarFabricante()
        {
            List<Veiculo> ordenados = veiculos.OrderBy(Veiculo => Veiculo.Fabricante).ToList();
            return ordenados;
        }

    }
}
