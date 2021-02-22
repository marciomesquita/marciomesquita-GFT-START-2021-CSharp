using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_04
{
    public class Ipi : IImposto
    {
        public double CalculaImposto(double valor)
        {
            if (valor < 25000)
            {
                valor *= 0.05;
                return valor;
            } 
            else
            {
                valor *= 0.10;
                return valor;
            }
        }
    }
}
