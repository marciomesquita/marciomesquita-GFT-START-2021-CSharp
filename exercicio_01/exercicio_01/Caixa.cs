using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_01
{
    class Caixa
    {
        public double CalculaValorFinal(Produto produto, int quantidade)
        {
            double valorTotal = produto.Valor * quantidade;

            if (produto.Tipo == 1)
            {
                valorTotal *= 0.90;
            }else if (produto.Tipo == 2){
                valorTotal *= 0.80;
            }
            else
            {
                if (quantidade > 5) 
                {
                    valorTotal *= 0.90;
                }
            }
            return valorTotal;
        }
    }
}
