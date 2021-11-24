using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Virtual.Cadastro.Aplicacao.ViewModels;
using Virtual.Cadastro.Dominio;
using Virtual.Cadastro.Servicos.Aplicacao;
using Virtual.Core.Data;

namespace Virtual.Cadastro.Aplicacao.Servicos
{
    public class ClienteAppServico : IClienteAppServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IMapper _mapper;

        public ClienteAppServico(IMapper mapper, IClienteRepositorio clienteRepositorio)
        {
            _mapper = mapper;
            _clienteRepositorio = clienteRepositorio;

        }

        public Task<IEnumerable<ClienteViewModel>> ObterClientesTodos(bool ativo)
        {
            throw new System.NotImplementedException();
        }

        public async Task AdicionarCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            _clienteRepositorio.AdicionarCliente(cliente);

            await _clienteRepositorio.UnitOfWork.Commit();
        }

        public async Task AtualizarCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            _clienteRepositorio.AtualizarCliente(cliente);

            await _clienteRepositorio.UnitOfWork.Commit();
        }       

        

        public interface IClienteRepositorio : IRepositorio<Cliente>
        {
            Task<IEnumerable<ClienteViewModel>> ObterClientesTodos(bool ativo);
            void AdicionarCliente(Cliente cliente);
            void AtualizarCliente(Cliente cliente);
        }
    }
}
