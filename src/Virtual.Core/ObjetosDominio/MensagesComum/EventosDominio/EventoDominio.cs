using MediatR;
using System;
using Virtual.Core.Messagens;

namespace Virtual.Core.ObjetosDominio.MensagesComum.EventosDominio
{
    public class EventoDominio : Mensagem, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected EventoDominio(Guid aggregateId)
        {
            AggregadoId = aggregateId;
            Timestamp = DateTime.Now;
        }
    }
}
