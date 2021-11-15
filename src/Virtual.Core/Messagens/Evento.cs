using MediatR;
using System;

namespace Virtual.Core.Messagens
{
    public class Evento : Mensagem, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Evento()
        {
            Timestamp = DateTime.Now;
        }
    }
}
