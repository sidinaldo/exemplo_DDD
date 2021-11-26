using Bogus;
using Bogus.Extensions.Brazil;
using System;
using System.Collections.Generic;
using System.Linq;
using Virtual.Cadastro.Dominio.Entidades;
using Xunit;

namespace Virtual.Teste.Cadastros.Cenarios
{
    [CollectionDefinition(nameof(EmpresasBogusCollection))]
    public class EmpresasBogusCollection : ICollectionFixture<Empresas>
    {

    }

    public class Empresas : IDisposable
    {
        public Empresa GerarEmpresaValida()
        {
            return GerarEmpresas(1, true).FirstOrDefault();
        }

        public IEnumerable<Empresa> ObterEmpresasVariadas()
        {
            var empresas = new List<Empresa>();

            empresas.AddRange(GerarEmpresas(50, true).ToList());
            empresas.AddRange(GerarEmpresas(50, false).ToList());

            return empresas;
        }

        public IEnumerable<Empresa> GerarEmpresas(int quantidade, bool ativo)
        {
            var empresas = new Faker<Empresa>()
                .CustomInstantiator(f => new Empresa(
                        f.Company.Cnpj(),
                        f.Company.CompanyName(),
                        f.Person.Phone,
                        ativo
                    ));

            return empresas.Generate(quantidade);
        }

        public Empresa GerarEmpresaCNPJInvalido()
        {
            var empresa = new Faker<Empresa>()
                 .CustomInstantiator(f => new Empresa(
                         "89910255003423",
                         f.Name.FullName(),
                         f.Person.Phone,
                         true
                     ));

            return empresa;
        }

        public Empresa GerarEmpresaNomeInvalido()
        {
            var empresa = new Faker<Empresa>()
                .CustomInstantiator(f => new Empresa(
                        f.Company.Cnpj(),
                        "Joi LTDA",
                        f.Person.Phone,
                        true
                    ));

            return empresa;
        }

        public void Dispose()
        {

        }
    }
}
