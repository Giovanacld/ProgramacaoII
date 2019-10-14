using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Funcionario
    {
        private string nome, email, fone;
        public Funcionario(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
        }
        public void SetNome(string n)
        {
            if (n != "") nome = n;
        }
        public void SetEmail(string e)
        {
            if (e != "") email = e;
        }
        public void SetFone(string f)
        {
            if (f != "") fone = f;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetFone()
        {
            return fone;
        }
        public override string ToString()
        {
            return $"{nome} {email} {fone}";
        }
    }
}
