using MSF.DesignPatterns._1___Decorator.Notifier.ConcretDecorator;
using MSF.DesignPatterns._1___Decorator.Notifier.Interface;
using MSF.DesignPatterns._1___Decorator.Notifier.Objects;
using MSF.DesignPatterns._1___Decorator.Pizza.ConcretDecorator;
using MSF.DesignPatterns._1___Decorator.Pizza.Interface;
using MSF.DesignPatterns._1___Decorator.Pizza.Objects;
using MSF.DesignPatterns._2___Factory_Method.ConcreteCreator.CartaoCredito;
using MSF.DesignPatterns._2___Factory_Method.Creator;
using MSF.DesignPatterns._3___Strategy.ConcreteStrategy;
using MSF.DesignPatterns._3___Strategy.Context;
using MSF.DesignPatterns._3___Strategy.Strategy;
using System;
using System.Diagnostics;

namespace MSF.DesignPatterns
{
    internal class Program
    {
        public static bool RunDecorator { get; set; } = false;
        public static bool RunFactoryMethod { get; set; } = false;
        public static bool RunStrategy { get; set; } = true;

        static void Main(string[] args)
        {
            #region Decorator - Structural

            if (RunDecorator)
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

            #endregion

            #region Factory Method - Creational

            if (RunFactoryMethod)
            {
                CartaoCreditoCreator cartaoCredito = null;


                Console.WriteLine("Cartão Credito Black - Digite 1");
                Console.WriteLine("Cartão Credito Platinum - Digite 2");
                Console.WriteLine("Cartão Credito Titanium - Digite 3");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        cartaoCredito = new CartaoBlackFactory(12000, 275);
                        break;
                    case "2":
                        cartaoCredito = new CartaoPlatinumFactory(18000, 500);
                        break;
                    case "3":
                        cartaoCredito = new CartaoTitaniumFactory(22000, 610);
                        break;
                    default:
                        break;
                }

                var obj = cartaoCredito.BuscarCartaoCredito();
                Console.WriteLine($"Tipo: {obj.Tipo}\nLimite: {obj.Limite}\nAnuidade: {obj.CobrancaAnual}");
                Console.ReadLine();
            }

            #endregion

            #region Strategy - Behavioral  

            if (RunStrategy)
            {
                var calculadora = new CalculadoraContext();

                calculadora.Add("sum", new Somar());
                calculadora.Add("sub", new Subtrair());
                calculadora.Add("mult", new Multiplicar());
                calculadora.Add("div", new Dividir());

                var operacao = Console.ReadLine();

                IStrategy acao = calculadora.Get(operacao);
                calculadora.Set(acao);

                Console.WriteLine($"Resultado: {calculadora.Calcular(1, 2)}");
            }

            #endregion
        }
    }
}
