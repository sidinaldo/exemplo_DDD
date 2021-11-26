using Virtual.Cadastro.Dominio.Entidades;
using Virtual.Cadastro.Dominio.Interfaces;
using Virtual.Core.Data;

namespace Virtual.Cadastro.Data.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly CadastroContext _context;

        public ClienteRepositorio(CadastroContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void AdicionarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
