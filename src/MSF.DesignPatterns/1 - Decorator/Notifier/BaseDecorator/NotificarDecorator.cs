using MSF.DesignPatterns._1___Decorator.Notifier.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._1___Decorator.Notifier.BaseDecorator
{
    public class NotificarDecorator : INotificar
    {
        public readonly INotificar _notificar;

        public NotificarDecorator(INotificar notificar)
        {
            _notificar = notificar;
        }

        public virtual string EnviarMensagem()
        {
            var notificar = _notificar.EnviarMensagem();
            return notificar;
        }
    }
}
