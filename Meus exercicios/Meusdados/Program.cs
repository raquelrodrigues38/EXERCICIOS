using System;

namespace Meusdados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double peso;
            int idade;


            Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("digite seu peso:");
            Double.TryParse(Console.ReadLine(), out peso);

            Console.WriteLine("digite sua idade:");
            int.TryParse(Console.ReadLine(), out idade);

            Console.WriteLine(" seu nome e");
            Console.WriteLine(nome);
            Console.WriteLine("seu peso e");
            Console.WriteLine(peso);
            Console.WriteLine("sua idade e");
            Console.WriteLine(idade);
        }

    }
}
