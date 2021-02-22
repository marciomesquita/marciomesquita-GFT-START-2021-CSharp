using System;
using System.Globalization;

namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtoUm = new Produto
            {
                Nome = "Banana",
                Valor = 0.99,
                Tipo = 2
            };

            var produtoDois = new Produto
            {
                Nome = "Energético",
                Valor = 5.49,
                Tipo = 3
            };

            var produtoTres = new Produto
            {
                Nome = "Arroz",
                Valor = 20.00,
                Tipo = 1
            };

            var produtoQuatro = new Produto
            {
                Nome = "Chocolate",
                Valor = 4.50,
                Tipo = 1
            };

            var produtoCinco = new Produto
            {
                Nome = "Leite",
                Valor = 3.73,
                Tipo = 3
            };

            var produtoSeis = new Produto
            {
                Nome = "Abacaxi",
                Valor = 2.40,
                Tipo = 2
            };

            var caixa = new Caixa();

            Console.Write($"{produtoUm.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoUm, 3).ToString("C2", CultureInfo.CurrentCulture));

            Console.Write($"{produtoDois.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoDois, 3).ToString("C2", CultureInfo.CurrentCulture));

            Console.Write($"{produtoTres.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoTres, 1).ToString("C2", CultureInfo.CurrentCulture));

            Console.Write($"{produtoQuatro.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoQuatro, 1).ToString("C2", CultureInfo.CurrentCulture));

            Console.Write($"{produtoCinco.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoCinco, 3).ToString("C2", CultureInfo.CurrentCulture));

            Console.Write($"{produtoSeis.Nome}: ");
            Console.WriteLine(caixa.CalculaValorFinal(produtoSeis, 2).ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}
