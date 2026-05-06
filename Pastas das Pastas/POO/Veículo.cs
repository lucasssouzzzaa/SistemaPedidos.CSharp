using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    // Classe Base (Super Base/ Modelo)
    public class Veículo
    {
        public string Marca;

        public int Ano;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Carro: {Marca}, Ano: {Ano}");
        }

    }
}