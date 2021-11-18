using MediatR;
using System;
using Virtual.Core.Messagens;

namespace Virtual.Core.ObjetosDominio.MensagesComum.Notificacoes
{
    public class NotificacaoDominio : Mensagem, INotification
    {
        public DateTime Timestamp { get; private set; }
        public Guid NotificacaoDominioId { get; private set; }
        public string Chave { get; private set; }
        public string Valor { get; private set; }
        public int Versao { get; private set; }

        public NotificacaoDominio(string chave, string valor)
        {
            Timestamp = DateTime.Now;
            NotificacaoDominioId = Guid.NewGuid();
            Chave = chave;
            Valor = valor;
            Versao = 1;
        }
    }
}
