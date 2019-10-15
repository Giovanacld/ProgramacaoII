using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Veiculo
    {
        private string placa, fabricante, modelo;
        private int ano;
        private bool vendido;
        private decimal preco;
        public string Fabricante { get => fabricante; }
        public Veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            modelo = m;
            ano = a;
            fabricante = f;
            preco = pr;
        }
        public void Vender() => vendido = true;
    }
}
