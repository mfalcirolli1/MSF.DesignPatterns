using MSF.DesignPatterns._1___Decorator.Notifier.Interface;

namespace MSF.DesignPatterns._1___Decorator.Notifier.Objects
{
    public class Notificar : INotificar
    {
        public string EnviarMensagem()
        {
            var mensagem = "Notificação de serviço: ";
            return mensagem;
        }
    }
}
