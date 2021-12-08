using AutoMapper;
using System.Threading.Tasks;
using Virtual.Cadastro.Aplicacao.ViewModels;
using Virtual.Cadastro.Dominio.Entidades;
using Virtual.Cadastro.Dominio.Interfaces;
using Virtual.Cadastro.Servicos.Aplicacao;

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

        public async Task AdicionarCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = _mapper.Map<Cliente>(clienteViewModel);

            if (!cliente.EhValido()) { return; };

            _clienteRepositorio.AdicionarCliente(cliente);

            await _clienteRepositorio.UnitOfWork.Commit();
        }

        public async Task AtualizarCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = _mapper.Map<Cliente>(clienteViewModel);

            if (!cliente.EhValido()) { return; };

            _clienteRepositorio.AtualizarCliente(cliente);

            await _clienteRepositorio.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            _clienteRepositorio?.Dispose();
        }
    }
}
