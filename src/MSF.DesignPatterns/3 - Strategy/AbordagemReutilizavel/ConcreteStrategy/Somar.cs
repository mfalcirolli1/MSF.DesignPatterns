﻿using MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Model;
using MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Strategy;

namespace MSF.DesignPatterns._3___Strategy.ConcreteStrategy
{
    public class Somar : IStrategy<Numeros, int>
    {
        public int Execute(Numeros numeros)
        {
            return numeros.Numero1 + numeros.Numero2;
        }
    }
}