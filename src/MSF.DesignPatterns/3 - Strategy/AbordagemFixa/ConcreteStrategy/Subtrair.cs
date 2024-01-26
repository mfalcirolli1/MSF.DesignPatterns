using MSF.DesignPatterns._3___Strategy.AbordagemFixa.Strategy;

namespace MSF.DesignPatterns._3___Strategy.AbordagemFixa.ConcreteStrategy
{
    public class Subtrair : ICalculadoraStrategy
    {
        public int Calcular(int a, int b)
        {
            return a - b;
        }
    }
}
