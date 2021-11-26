using Virtual.Core.ObjetosDominio;
using Virtual.Teste.Cadastros.Cenarios;
using Xunit;

namespace Virtual.Teste.Cadastros.Entidades
{
    [Collection(nameof(EmpresasBogusCollection))]
    public class EmpresaTest
    {
        private readonly Empresas _empresas;
        public EmpresaTest(Empresas empresas)
        {
            _empresas = empresas;
        }

        [Fact]
        public void Empresa_NovaEmpesa_DeveEstarValido()
        {
            //Arrange
            var empresa = _empresas.GerarEmpresaValida();

            //Assert
            Assert.NotNull(empresa);

        }

        [Fact]
        public void Empresa_NovoEmpresa_DeveEstarCNPJInvalido()
        {
            //Arrange e Act
            var ex = Assert.Throws<ExcecaoDominio>(() =>
                 _empresas.GerarEmpresaCNPJInvalido()
             );

            //Assert
            Assert.Equal("O CNPJ é inválido.", ex.Message);

        }

        [Fact]
        public void Empresa_NovoEmpresa_DeveEstarNomeInvalido()
        {
            //Arrange e Act
            var ex = Assert.Throws<ExcecaoDominio>(() =>
                 _empresas.GerarEmpresaNomeInvalido()
             );

            //Assert
            Assert.IsType<ExcecaoDominio>(ex);
            Assert.Equal("O campo Nome do fornecedor não pode ser menor que 10 caractéres e maior que 120.", ex.Message);

        }
    }
}
