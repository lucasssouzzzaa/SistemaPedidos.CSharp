namespace Repetição_C_;

class Program
{
    static void Main(string[] args)
    {
       /*
       for -> é uma estrutura de repetição ideal para quando se sabe exatamente quantas vezes um bloco de código deve ser executado. Ele utiliza uma sintax

       while -> usado para quando você não sabe quantas vezes vai repetir e a repetição acontece enquanto uma condição for verdadeira

       do/while -> é o parecido com while, mas a diferença é que mesmo que a condição seja falsa, ele executa pelo menos uma vez: "faz primeiro e depois pergunta".

       forEach -> usado para percorrer listas
       */

       // Exemplo FOR 

       // 1- int i = 1  -> inicializador, valor inicial
       // 2- i <= 5  -> condição, se for verdadeiro, continua executando
       // 3- i++  -> iterador, acresenta um valor a mais dentro do i
       //      (i = i + 1)

    //    for(int i = 1; i <= 5; i++)
    //    {
    //     Console.WriteLine(i);
    //    }

    // int soma = 0;

    // for(int i = 1; i <= 10; i++)
    // {
    //     soma = soma + i;
    //     //soma += 1;  -> pode ser feito assim
    // Console.WriteLine("Soma atual: " + soma); 
    // } 

    // Console.WriteLine("Soma: " + soma);

    // Exemplo WHILE 
    // int contador = 5;

    // while(contador > 5)
    // {
    //     Console.WriteLine("Primeiro contador: " + contador);
    //      contador = contador + 1;
    //      contador--;
    //     Console.WriteLine("Segundo contador:" + contador);
    // }
    
    //  Console.WriteLine("Contador final: " + contador);

    // int numero = 5; 
    // int resultado = numero++;

    // Console.WriteLine(numero);
    // Console.WriteLine(resultado);

    // int numero = 0;

    // while(numero <= 0)
    // {
    //     Console.Write("Digite um número maior que zero: ");
    //     numero = int.Parse(Console.ReadLine());
    // }
    // Console.WriteLine("Número válido: " + numero);

    //Exemplo DO/WHILE
    // int numero;

    // do // faça
    // {
    //      Console.Write("Digite um número maior que zero: ");
    //      numero = int.Parse(Console.ReadLine())
    // }
    // while (numero <= 0); //enquanto condição for verdadeira

    // Console.WriteLine("Número válido: " + numero);

    //menu
    // int opcao;

    // do
    // {
    //     Console.WriteLine("1 - Continuar");
    //     Console.WriteLine("2 - Sair");
    //     opcao = int.Parse(Console.ReadLine());
    // } while(opcao != 2);

    // Console.WriteLine("Programa encerrado");

    //Exemplo FOREACH
    // string[] nomes = { "Ana", "Carlos", "Maria", "Rodrigo"} // ou pode ser feita assim "string[] nomes = new string [10]"

    // // para cada nome na lista nomes
    // foreach (string nome in nomes)
    // {
    //     // imprima o nome
    //     Console.WriteLine("nome")
    // }

    // int[] numeros = {2, 4, 6, 8};
    // int soma = 0;

    // foreach(int numero in numeros)
    // {
    //     soma += numero;
    //     // soma = soma + numero;
    // }

    // Console.WriteLine("Soma: " + soma);
    }
}
