using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*desenvolver uma calculadora
             *que vai ler um numero
             *depois vai ler o segundo numero
             *depois vai ler o operador
             *como resposta o programa
             *responder o resultado da operação
             */
            //ler o primeiro numero
            //ler o segundo numero
            //ler o operador + - * /
            //verificar o tipo do operador
            //realizar a operação conforme o tipo verificado
            //imprimir o resultado
            Double numero1;
            Double numero2;
            Double operador;
            Double resultado;


            Console.WriteLine("digite numero1");
            Double.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("digite o numero2");
            Double.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("operacao:1 para soma, 2 para subtracao, 3 para multiplicação, 4 para divisao");
            Double.TryParse(Console.ReadLine(), out operador);

            if (operador == 1)
            {
                resultado = numero1 + numero2;
                Console.WriteLine("o resultado da soma e");
                Console.WriteLine(resultado);




            }
            if (operador == 2)

            {
                resultado = numero1 - numero2;
                Console.WriteLine("o resultado da subtracao e");
                Console.WriteLine(resultado);



            }
            if (operador == 3)

            {
                resultado = numero1 * numero2;
                Console.WriteLine("o resultado da multiplicacao e");
                Console.WriteLine(resultado);


            }
            if (operador == 4 && numero2 !=0)

            {
                resultado = numero1 / numero2;
                Console.WriteLine("o resultado  da divisao e");
                Console.WriteLine(resultado);



            }
            else if (operador == 4)
            {


                if (numero2 == 0)
                {
                    Console.WriteLine("impossivel dividir");
                }

            }  


            










        }
    }
}
