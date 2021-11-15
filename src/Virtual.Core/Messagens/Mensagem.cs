using System;

namespace Virtual.Core.Messagens
{
    public class Mensagem
    {
        public string MensagemType { get; protected set; }
        public Guid AggregadoId { get; protected set; }

        protected Mensagem()
        {
            MensagemType = GetType().Name;
        }
    }
}
