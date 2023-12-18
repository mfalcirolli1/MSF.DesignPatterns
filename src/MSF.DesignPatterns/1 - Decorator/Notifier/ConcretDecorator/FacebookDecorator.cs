using MSF.DesignPatterns._1___Decorator.Notifier.BaseDecorator;
using MSF.DesignPatterns._1___Decorator.Notifier.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.DesignPatterns._1___Decorator.Notifier.ConcretDecorator
{
    public class FacebookDecorator : NotificarDecorator
    {
        public FacebookDecorator(INotificar notificar) : base(notificar)
        {
        }

        public override string EnviarMensagem()
        {
            var notificar = base.EnviarMensagem();
            notificar += "via Facebook!";
            return notificar;
        }
    }
}
