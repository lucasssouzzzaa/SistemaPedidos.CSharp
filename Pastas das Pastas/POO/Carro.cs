using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    // Classe Derivada (subclasse) -> herda info de veiculo
    public class Carro : Veículo
    {
      //  public string Marca;

        public string Modelo;

       // public int Ano;

        // Métodos (ações que a classe pode realizar)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}