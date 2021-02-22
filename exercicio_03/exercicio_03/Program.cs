using System;

namespace exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int[] divisores = new int[] {3,6,7};

            Console.Write("Divisível por ");

            foreach(int divisor in divisores)
            {
                if (numero % divisor == 0)
                {
                    Console.Write($"{divisor} ");
                }

                
            }

        }
    }
}
