using MSF.DesignPatterns._1___Decorator.Pizza.Interface;

namespace MSF.DesignPatterns._1___Decorator.Pizza.BaseDecorator
{
    // Base Decorator

    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }
}
