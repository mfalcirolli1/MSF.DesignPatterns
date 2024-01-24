using MSF.DesignPatterns._3___Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSF.DesignPatterns._3___Strategy.Context
{
    public class CalculadoraContext
    {
        private ICalculadoraStrategy _strategy;
        private readonly Dictionary<string, ICalculadoraStrategy> _dictionaryStrategy = new Dictionary<string, ICalculadoraStrategy>();

        public void Add(string key, ICalculadoraStrategy strategy)
        {
            _dictionaryStrategy.Add(key, strategy);
        }

        public ICalculadoraStrategy Get(string key)
        {
            var strategy = _dictionaryStrategy.FirstOrDefault(x => x.Key == key).Value;
            return strategy;
        }

        public void Set(ICalculadoraStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Calcular(int a, int b)
        {
            return _strategy.Calcular(a, b);
        }
    }
}
