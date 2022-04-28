using System;

namespace Meu_primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.WriteLine("digite nota 1");
            Double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("digite nota 2");
            Double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("digite nota 3");
            Double.TryParse(Console.ReadLine(), out nota3);

            Console.WriteLine("nota 1 digitada e:");
            Console.WriteLine(nota1);

            Console.WriteLine("nota 2 digitada e:");
            Console.WriteLine(nota2);

            Console.WriteLine("nota 3 digitada e:");
            Console.WriteLine(nota3);

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Sua media e:");
            Console.WriteLine(media);

            if(media >= 7)
            { 

        Console.WriteLine("Aprovado");
            }
    else
            { 
        Console.WriteLine("Reprovado");


    }

                
        }
    }
}
