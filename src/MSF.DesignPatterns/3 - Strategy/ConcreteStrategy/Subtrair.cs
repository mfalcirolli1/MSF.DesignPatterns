using MSF.DesignPatterns._3___Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._3___Strategy.ConcreteStrategy
{
    public class Subtrair : ICalculadoraStrategy
    {
        public int Calcular(int a, int b)
        {
            return a - b;
        }
    }
}
