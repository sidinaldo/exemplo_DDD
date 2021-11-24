using System.Collections.Generic;
using System.Threading.Tasks;
using Virtual.Cadastro.Aplicacao.ViewModels;

namespace Virtual.Cadastro.Servicos.Aplicacao
{
    public interface IClienteAppServico
    {
        Task<IEnumerable<ClienteViewModel>> ObterClientesTodos(bool ativo);
        Task AdicionarCliente(ClienteViewModel clienteViewModel);
        Task AtualizarCliente(ClienteViewModel clienteViewModel);
    }
}
