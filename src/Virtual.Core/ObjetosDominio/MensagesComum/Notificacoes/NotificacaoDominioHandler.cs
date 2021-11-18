using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Virtual.Core.ObjetosDominio.MensagesComum.Notificacoes;

namespace NerdStore.Core.Messages.CommonMessages.Notifications
{
    public class NotificacaoDominioHandler : INotificationHandler<NotificacaoDominio>
    {
        private List<NotificacaoDominio> _notificacoes;

        public NotificacaoDominioHandler()
        {
            _notificacoes = new List<NotificacaoDominio>();
        }

        public Task Handle(NotificacaoDominio message, CancellationToken cancellationToken)
        {
            _notificacoes.Add(message);
            return Task.CompletedTask;
        }

        public virtual List<NotificacaoDominio> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public virtual bool TemNotificacao()
        {
            return ObterNotificacoes().Any();
        }

        public void Dispose()
        {
            _notificacoes = new List<NotificacaoDominio>();
        }
    }
}