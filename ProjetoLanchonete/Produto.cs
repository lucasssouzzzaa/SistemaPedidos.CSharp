using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public abstract class Produto
    {
        public string nome;

        private decimal precoBase;
        public decimal PrecoBase
        {
            get { return precoBase; }
            set
            {
                if (value < 0)
                    precoBase = 0;
                else
                    precoBase = value;
            }
        }

        public decimal precoFinal;

        public abstract void CalcularPrecoFinal();

        public void ExibirResumo()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço final: R$ {precoFinal:F2}");
        }
    }
}