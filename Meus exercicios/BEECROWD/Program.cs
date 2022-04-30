using System;

namespace BEECROWD
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int A, B;
            int X;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);

            X = A + B;
            Console.WriteLine("X = "+X);

        }
    }
}
