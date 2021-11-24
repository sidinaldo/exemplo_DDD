using System.Collections.Generic;
using System.Threading.Tasks;
using Virtual.Cadastro.Aplicacao.ViewModels;
using Virtual.Cadastro.Dominio;
using Virtual.Core.Data;
using static Virtual.Cadastro.Aplicacao.Servicos.ClienteAppServico;

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
            throw new System.NotImplementedException();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ClienteViewModel>> ObterClientesTodos(bool ativo)
        {
            throw new System.NotImplementedException();
        }
    }
}
