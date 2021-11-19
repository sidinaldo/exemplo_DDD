using Bogus;
using Bogus.DataSets;
using Bogus.Extensions.Brazil;
using System;
using System.Collections.Generic;
using System.Linq;
using Virtual.Cadastro.Dominio;
using Xunit;

namespace Virtual.Teste.Cadastros.Cenarios
{
    [CollectionDefinition(nameof(ClienteBogusCollection))]
    public class ClienteBogusCollection : ICollectionFixture<Clientes>
    {

    }

    public class Clientes : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            return GerarClientes(1, true).FirstOrDefault();
        }

        public IEnumerable<Cliente> ObterClientesVariados()
        {
            var clientes = new List<Cliente>();

            clientes.AddRange(GerarClientes(50, true).ToList());
            clientes.AddRange(GerarClientes(50, false).ToList());

            return clientes;
        }

        public IEnumerable<Cliente> GerarClientes(int quantidade, bool ativo)
        {
            var clientes = new Faker<Cliente>()
                .CustomInstantiator(f => new Cliente(
                        f.Person.Cpf(),
                        f.Name.FullName(),
                        f.Date.Past(80, DateTime.Now.AddYears(-18)),
                        ativo
                    ));

            return clientes.Generate(quantidade);
        }

        public Cliente GerarClienteCPFInvalido()
        {
            var cliente = new Faker<Cliente>()
                 .CustomInstantiator(f => new Cliente(
                         "23456787645",
                         f.Name.FullName(),
                         f.Date.Past(80, DateTime.Now.AddYears(-18)),
                         true
                     ));

            return cliente;
        }

        public Cliente GerarClienteNomeInvalido()
        {
            var cliente = new Faker<Cliente>()
                .CustomInstantiator(f => new Cliente(
                        f.Person.Cpf(),
                        "Naldo",
                        f.Date.Past(80, DateTime.Now.AddYears(-18)),
                        true
                    ));

            return cliente;
        }

        public void Dispose()
        {

        }
    }
}
