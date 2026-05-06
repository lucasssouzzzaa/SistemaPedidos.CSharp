namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // definindo valores para os atributos
        Carro meuCarro = new Carro();

        // definindo valores para atributos
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        // Chamando o método
        meuCarro.ExibirInformacoes();

        // INSTANCIANDO O OBJ MOTO
        Moto minhaMoto = new Moto();
        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = "2021";
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirDetalhesMoto();
    }
}
