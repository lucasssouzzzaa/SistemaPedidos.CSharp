using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public class Lanche : Produto
    {
        public override void CalcularPrecoFinal()
        {
            precoFinal = PrecoBase + 2.00m;
        }

        public void ExibirTipo()
        {
            Console.WriteLine("Tipo: Lanche");
        }
    }
}