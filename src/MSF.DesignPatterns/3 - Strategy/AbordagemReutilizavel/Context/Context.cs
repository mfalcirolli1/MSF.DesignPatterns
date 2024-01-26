using MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Context
{
    public class Context<TResponse, TRequest, TSearch>
    {
        private IStrategy<TRequest, TResponse> _strategy;
        private readonly Dictionary<TSearch, IStrategy<TRequest, TResponse>> _dictionaryStrategy = new Dictionary<TSearch, IStrategy<TRequest, TResponse>>();

        public void Add(TSearch key, IStrategy<TRequest, TResponse> strategy)
        {
            _dictionaryStrategy.Add(key, strategy);
        }

        public void Set(TSearch acao)
        {
            _strategy = _dictionaryStrategy.FirstOrDefault(x => x.Key.GetHashCode() == acao.GetHashCode()).Value;
        }

        public TResponse Execute(TRequest request)
        {
            var strategy = _strategy.GetType();
            var notify = strategy.GetMethod("Execute");
            var instance = Activator.CreateInstance(_strategy.GetType());
            return (TResponse)notify.Invoke(instance, new object[] { request });
        }
    }
}
