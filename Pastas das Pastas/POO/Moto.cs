using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Moto : Veículo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto()
        {
            ExibirDetalhes(); // método herdado de veiculo
            Console.WriteLine($"Partida elétrica: {TemPartidaEletrica}");
        }
    }
}