using System;

namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escrever um programa que 
             * vai ler 3 notas de prova
             * sendo que
             * a primeira prova tem peso 30%
             * a segunda prova tem peso de 50%
             * a terceira prova tem peso 20%
             * ao final, imprimir a media
             * e dizer se o akuno foi aprovado
             * ou nao
             */
            const Double prova1 = 0.30;
            const Double prova2 = 0.50;
            const Double prova3 = 0.20;


            
            Double nota1, nota2, nota3;
            Double media;

            Console.WriteLine("digite a nota1");
            Double.TryParse(Console.ReadLine(), out nota1);
            Console.WriteLine("digite a nota2");
            Double.TryParse(Console.ReadLine(), out nota2);
            Console.WriteLine(" digite a nota3");
            Double.TryParse(Console.ReadLine(), out nota3);
            media = (nota1 * prova1 + nota2 * prova2 + nota3 * prova3);






                

        }
    }
}
