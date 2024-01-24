using MSF.DesignPatterns._3___Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSF.DesignPatterns._3___Strategy.Context
{
    public class CalculadoraContext
    {
        private IStrategy _strategy;
        private readonly Dictionary<string, IStrategy> _dictionaryStrategy = new Dictionary<string, IStrategy>();

        public void Add(string key, IStrategy strategy)
        {
            _dictionaryStrategy.Add(key, strategy);
        }

        public IStrategy Get(string key)
        {
            var strategy = _dictionaryStrategy.FirstOrDefault(x => x.Key == key).Value;
            return strategy;
        }

        public void Set(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Calcular(int a, int b)
        {
            return _strategy.Calcular(a, b);
        }
    }
}
