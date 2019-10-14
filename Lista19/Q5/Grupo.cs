using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Grupo
    {
        private string descricao;
        private Contato[] contatos;
        private int k;
        public override string ToString()
        {
            return $"Descrição:{descricao} Número de contatos{k}";
        }
        public void AdicionarContato(Contato c)
        {
            contatos[j++] = c;
        }
        public Contato[] ListarContatos()
        {
            Contato[] novo = new Contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }
        public void Remover(int c)
        {
            if (c < k)
            {
                for (int i = c + 1; i < k; i++)
                    contatos[i - 1] = contatos[i];
                k--;
            }
        }
    }
}
