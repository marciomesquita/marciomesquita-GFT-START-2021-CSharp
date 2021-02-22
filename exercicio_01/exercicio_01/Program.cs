using System;
using System.Collections.Generic;
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

            var cesta = new Dictionary<Produto, int>
            {
                { produtoUm, 3 },
                { produtoDois, 7},
                { produtoTres, 1 },
                { produtoQuatro, 20 },
                { produtoCinco , 3 },
                { produtoSeis, 4 }
            };

            var caixa = new Caixa();

            foreach (var item in cesta)
            {
                var valorFinal = caixa.CalculaValorFinal(item.Key, item.Value);

                Console.WriteLine($"{item.Key.Nome}: {valorFinal.ToString("C2", CultureInfo.CurrentCulture)}");
            }
        }
    }
}
