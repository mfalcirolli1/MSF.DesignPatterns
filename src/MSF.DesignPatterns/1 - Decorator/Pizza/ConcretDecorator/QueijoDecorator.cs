using MSF.DesignPatterns._1___Decorator.Pizza.BaseDecorator;
using MSF.DesignPatterns._1___Decorator.Pizza.Interface;

namespace MSF.DesignPatterns._1___Decorator.Pizza.ConcretDecorator
{
    // Concret Decorator

    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += " + Queijo";
            return pizza;
        }
    }
}
