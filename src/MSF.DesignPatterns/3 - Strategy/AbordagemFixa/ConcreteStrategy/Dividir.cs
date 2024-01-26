using MSF.DesignPatterns._3___Strategy.AbordagemFixa.Strategy;
using System;

namespace MSF.DesignPatterns._3___Strategy.AbordagemFixa.ConcreteStrategy
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
