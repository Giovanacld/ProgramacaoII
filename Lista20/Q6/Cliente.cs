using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Cliente
    {
        private string nome, cpf;
        private decimal limite;
        private List<Cliente> socio;
        public decimal LimiteTotal{ get =>  limite; }
        public string Nome { get => nome; }
        public bool TemSocio(int t)
        {
            if (socio != null) return true;
            else return false;
        }
        public Cliente(string n, string c, decimal l)
        {
            nome = n;
            cpf = c;
            limite = l;
        }
        public void Inserir(Cliente c)
        {
            socio.Add(c);
        }
        public void Excluir(Cliente c)
        {
            socio.Remove(c);
        }

    }
}
