using MSF.DesignPatterns._1___Decorator.Notifier.ConcretDecorator;
using MSF.DesignPatterns._1___Decorator.Notifier.Interface;
using MSF.DesignPatterns._1___Decorator.Notifier.Objects;
using MSF.DesignPatterns._1___Decorator.Pizza.ConcretDecorator;
using MSF.DesignPatterns._1___Decorator.Pizza.Interface;
using MSF.DesignPatterns._1___Decorator.Pizza.Objects;
using System.Diagnostics;

namespace MSF.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Debugger.Break();

            IPizza pizza = new Pizza();
            IPizza pizzaComQueijo = new QueijoDecorator(pizza); // Queijo -> Base -> Classe inicial (pizza)
            IPizza pizzaComBacon = new BaconDecorator(pizzaComQueijo); // Bacon -> Base -> Queijo
            IPizza pizzaComCebola = new CebolaDecorator(pizzaComBacon); // Cebola -> Base -> Bacon

            Debug.WriteLine(pizzaComCebola.BuscarTipoPizza());

            INotificar notificar = new Notificar();
            INotificar notificarSMS = new SMSDecorator(notificar);
            INotificar notificarFacebook = new FacebookDecorator(notificar);

            Debug.WriteLine(notificarSMS.EnviarMensagem());
            Debug.WriteLine(notificarFacebook.EnviarMensagem());

            // Lê-se as calls da: ESQUERDA para a DIREITA, de BAIXO pra CIMA
            // Lê-se os retornos da: DIREITA para a ESQUERDA, de CIMA pra baixo
        }
    }
}
