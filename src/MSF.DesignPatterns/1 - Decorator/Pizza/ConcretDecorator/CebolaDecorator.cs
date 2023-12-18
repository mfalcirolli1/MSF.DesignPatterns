using MSF.DesignPatterns._1___Decorator.Pizza.BaseDecorator;
using MSF.DesignPatterns._1___Decorator.Pizza.Interface;

namespace MSF.DesignPatterns._1___Decorator.Pizza.ConcretDecorator
{
    // Concret Decorator

    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += " + Cebola";
            return pizza;
        }
    }
}
