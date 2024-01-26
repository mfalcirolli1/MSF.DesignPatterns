using MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Model;
using MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Strategy;
using System;

namespace MSF.DesignPatterns._3___Strategy.ConcreteStrategy
{
    public class Dividir : IStrategy<Numeros, int>
    {
        public int Execute(Numeros numeros)
        {
            if (numeros.Numero2 == 0)
                throw new DivideByZeroException();

            return numeros.Numero1 / numeros.Numero2;
        }
    }
}
