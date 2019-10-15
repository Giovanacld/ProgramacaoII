using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Empresa : Cliente
    {
        private List<Cliente> cs;
        public void Inserir(Cliente c)
        {
            cs.Add(c);
        }
        public void Excluir(Cliente c)
        {
            cs.Remove(c);
        }
        public void Socios(Cliente x, Cliente y)
        {
            x.Inserir(y); y.Inserir(x);
        }
        public List<Cliente> ListarNome()
        {
            List<Cliente> ordenados = cs.OrderBy(Cliente => Cliente.Nome).ToList();
            return ordenados;
        }
        public List<Cliente> ListarLimite()
        {
            List<Cliente> ordenados = cs.OrderByDescending(Cliente => Cliente.LimiteTotal).ToList();
            return ordenados;
        }
        public List<Cliente> ListarNaoSocios()
        {
            List<Cliente> c = new List<Cliente>();
            foreach (Cliente i in cs)
            {
                if (cs.TemSocio == false) c.Add(i);  
            }
            return c;
        }
    }

}
