using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Usuario : Contato
    {
        private Contato[] contatos;
        private Grupo[] grupos;
        private int k, j; // grupo (k) contato (j)
        public Usuario(string n, string f) : base(n, f) { }
        public override string ToString()
        {  //como eu referencio o nome e o fone se eles tão no msm metodo? e os vetores?
            return $"Nome:{base.nome}  Fone{base.fone} Total de Grupos:{k} Total de Contatos{j}";
        }
        public void InserirGrupo(Grupo g)
        {
            grupos[k++] = g;
        }
        public void InserirContato(Contato c)
        {
            contatos[j++] = c;
        }
        public Contato[] ListarContatos()
        {
            Contato[] novo = new Contato[j];
            Array.Copy(contatos, novo, j);
            return novo;
        }
        public Grupo[] ListarGrupos()
        {
            Grupo[] novo = new Grupo[k];
            Array.Copy(grupos, novo, k);
            return novo;
        }
    }
