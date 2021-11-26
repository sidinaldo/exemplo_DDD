using System;
using System.Threading.Tasks;
using Virtual.Cadastro.Aplicacao.ViewModels;

namespace Virtual.Cadastro.Servicos.Aplicacao
{
    public interface IClienteAppServico : IDisposable
    {
        Task AdicionarCliente(ClienteViewModel clienteViewModel);
        Task AtualizarCliente(ClienteViewModel clienteViewModel);
    }
}
