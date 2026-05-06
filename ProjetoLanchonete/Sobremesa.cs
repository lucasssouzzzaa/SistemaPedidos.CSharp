using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public class Sobremesa : Produto, IDesconto
    {
        public decimal desconto;

        public override void CalcularPrecoFinal()
        {
            precoFinal = PrecoBase;
        }

        public void AplicarDesconto()
        {
            desconto = precoFinal * 0.10m;
            precoFinal -= desconto;
        }

        public void ExibirTipo()
        {
            Console.WriteLine("Tipo: Sobremesa");
        }
    }
}