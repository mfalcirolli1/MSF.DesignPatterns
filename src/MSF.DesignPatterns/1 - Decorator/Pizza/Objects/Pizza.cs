using MSF.DesignPatterns._1___Decorator.Pizza.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._1___Decorator.Pizza.Objects
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Pizza Normal";
            return pizza;
        }
    }
}
