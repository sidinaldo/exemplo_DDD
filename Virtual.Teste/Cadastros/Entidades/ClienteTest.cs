using System;
using System.Linq;
using Virtual.Cadastro.Dominio;
using Virtual.Core.ObjetosDominio;
using Virtual.Teste.Cadastros.Cenarios;
using Xunit;

namespace Virtual.Teste.Cadastros.Entidades
{
    [Collection(nameof(ClienteBogusCollection))]
    public class ClienteTest
    {
        private readonly Clientes _clientes;
        public ClienteTest(Clientes clientes)
        {
            _clientes = clientes;
        }

        [Fact]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            //Arrange
            var cliente = _clientes.GerarClienteValido();            

            //Assert
            Assert.NotNull(cliente);

        }

        [Fact]
        public void Cliente_NovoCliente_DeveEstarCPFInvalido()
        {
            //Arrange e Act
            var ex = Assert.Throws<ExcecaoDominio>(() =>
                 _clientes.GerarClienteCPFInvalido()
             );

            //Assert
            Assert.Equal("O CPF é inválido.", ex.Message);

        }

        [Fact]
        public void Cliente_NovoCliente_DeveEstarNomeInvalido()
        {
            //Arrange e Act
            var ex = Assert.Throws<ExcecaoDominio>(() =>
                 _clientes.GerarClienteNomeInvalido()
             );

            //Assert
            Assert.Equal("O campo Nome do cliente não pode ser menor que 10 caractéres e maior que 100.", ex.Message);

        }
    }
}
