using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_04
{
    public class Cofins : IImposto
    {
        public double CalculaImposto(double valor)
        {
            if (valor > 12000)
            {
                valor *= 0.08;
                return valor;
            }
            else
            {
                return 0;
            }
        }
    }
}
