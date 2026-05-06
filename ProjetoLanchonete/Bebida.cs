using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public class Bebida : Produto
    {
        public override void CalcularPrecoFinal()
        {
            precoFinal = PrecoBase;
        }

        public void ExibirTipo()
        {
            Console.WriteLine("Tipo: Bebida");
        }
    }
}
