using Virtual.Cadastro.Dominio.Entidades;
using Virtual.Core.Data;

namespace Virtual.Cadastro.Dominio.Interfaces
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
    }
}
