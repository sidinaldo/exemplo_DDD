using System;

namespace Virtual.Core.Messagens
{
    public class Mensagem
    {
        public string TipoMensagem { get; protected set; }
        public Guid AggregadoId { get; protected set; }

        protected Mensagem()
        {
            TipoMensagem = GetType().Name;
        }
    }
}
