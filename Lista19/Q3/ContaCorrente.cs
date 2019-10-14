using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class ContaCorrente
    {
        private string titular, numconta;
        protected double saldo;
        public ContaCorrente(string t, string n)
        {
            titular = t;
            numconta = n;
        }
        public void Depositar(double v)
        {
            saldo += v;
        }
        public virtual bool Sacar(double v)
        {
            if (saldo - v < 0) return false;
            else
            {
                saldo -= v;
                return true;
            }
        }
        public double RetornarSaldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            return $"{titular} {numconta} {saldo}";
        }
    }
}
