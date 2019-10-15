using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Agenda : Contato
    {
        private List<Contato> cs;
        public void Inserir(Contato c)
        { cs.Add(c); }
        public List<Contato> Listar()
        { return cs; }
        public List<Contato> Pesquisar(string inicio)
        {
            List<Contato> pes = new List<Contato>();
            foreach (Contato k in cs)
            {           //pl = primeira letra
                string pl = k.Nome.Substring(0, 1);
                pes.Add(k);
            }
            return pes;
        }
        public void Abrir()
        {

        }
        public void Fechar()
        {

        }
    }
}
