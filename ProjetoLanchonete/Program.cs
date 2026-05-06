using System;

namespace ProjetoLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ㅤㅤㅤ PEDIDO ㅤㅤㅤ");

            Lanche lanche = new Lanche();
            lanche.nome = "X-Burguer";
            lanche.PrecoBase = 18.00m;
            lanche.CalcularPrecoFinal();

            Bebida bebida = new Bebida();
            bebida.nome = "Refrigerante";
            bebida.PrecoBase = 6.00m;
            bebida.CalcularPrecoFinal();

            Sobremesa sobremesa = new Sobremesa();
            sobremesa.nome = "Pudim";
            sobremesa.PrecoBase = 8.00m;
            sobremesa.CalcularPrecoFinal();
            sobremesa.AplicarDesconto();

            lanche.ExibirTipo();
            lanche.ExibirResumo();
            Console.WriteLine();

            bebida.ExibirTipo();
            bebida.ExibirResumo();
            Console.WriteLine();

            sobremesa.ExibirTipo();
            sobremesa.ExibirResumo();
            Console.WriteLine($"Desconto: R$ {sobremesa.desconto:F2}\n");

            decimal total = lanche.precoFinal + bebida.precoFinal + sobremesa.precoFinal;

            Console.WriteLine($"TOTAL DO PEDIDO: R$ {total:F2}");

            Console.ReadLine();
        }
    }
}