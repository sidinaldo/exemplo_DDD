using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using Virtual.Core.Messagens;

namespace Virtual.Core.ObjetosDominio
{
    public class EntidadeBase
    {
        public Guid Id { get; set; }
        private List<Evento> _notificacoes;
        public IReadOnlyCollection<Evento> Notificacoes => _notificacoes?.AsReadOnly();

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }

        public void AdicionarEvento(Evento evento)
        {
            _notificacoes ??= new List<Evento>();
            _notificacoes.Add(evento);
        }

        public void RemoverEvento(Evento evento)
        {
            _notificacoes?.Remove(evento);
        }

        public void LimparEventos()
        {
            _notificacoes?.Clear();
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntidadeBase;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntidadeBase a, EntidadeBase b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntidadeBase a, EntidadeBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
