using MSF.DesignPatterns._3___Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._3___Strategy.ConcreteStrategy
{
    public class Dividir : ICalculadoraStrategy
    {
        public int Calcular(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }
    }
}
