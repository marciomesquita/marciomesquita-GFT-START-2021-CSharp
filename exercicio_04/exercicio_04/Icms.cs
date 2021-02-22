using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_04
{
    public class Icms : IImposto
    {
        public double CalculaImposto(double valor)
        {
            valor *= 0.30;
            return valor;
        }
    }
}
