﻿using System;

namespace exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            var icms = new Icms();
            var ipi = new Ipi();
            var cofins = new Cofins();

            Console.WriteLine($"ICMS: {icms.CalculaImposto(valor).ToString("N2")}");
            Console.WriteLine($"IPI: {ipi.CalculaImposto(valor).ToString("N2")}");
            Console.WriteLine($"COFINS: {cofins.CalculaImposto(valor).ToString("N2")}");

            double valorTotalImpostos = icms.CalculaImposto(valor) + ipi.CalculaImposto(valor) + cofins.CalculaImposto(valor);
            double valorTotal = valor + valorTotalImpostos;

            Console.WriteLine($"Valor Final: {valorTotal.ToString("N2")}");
        }
    }
}
