using System;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o intervalo inicial: ");
            int intervaloInicial = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o intervalo final: ");
            int intervaloFinal= Convert.ToInt32(Console.ReadLine());

            bool dentroDoIntervalo = (intervaloFinal - intervaloInicial < 15);

            if (dentroDoIntervalo)
            {
                for (int i = intervaloInicial; i <= intervaloFinal; i++)
                {
                    var cuboDoNumero = Math.Pow(i, 3);
                    Console.WriteLine($"Cubo de {i}:{cuboDoNumero}");
                }
            }

            



        }
    }
}
