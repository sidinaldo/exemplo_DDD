using System;
using Virtual.Core.ObjetosDominio;

namespace Virtual.Core.Data
{
    public interface IRepositorio<T> : IDisposable where T : IAgregadorRaiz
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
