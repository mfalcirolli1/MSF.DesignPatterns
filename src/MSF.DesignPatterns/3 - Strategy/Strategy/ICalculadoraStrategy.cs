﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._3___Strategy.Strategy
{
    public interface ICalculadoraStrategy
    {
        public int Calcular(int a, int b);
    }
}