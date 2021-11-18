using System;
using Virtual.Core.ObjetosDominio;
using Virtual.Core.Utils;

namespace Virtual.Cadastro.Dominio
{
    public class Cliente : EntidadeBase, IAgregadorRaiz
    {       

        public bool Ativo { get; private set; }
        public Guid PessoaId { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Pessoa Pessoa { get; private set; }

        protected Cliente() 
        {
        }

        public Cliente(string cpf, string nome, DateTime dataNascimento, bool ativo = true)
        {
            Id = Guid.NewGuid(); 
            DataCadastro = DateTime.Now;
            Ativo = ativo;
            Pessoa = new Pessoa(cpf, nome, dataNascimento);

            //Validar();
            AssociarPessoa();
        }


        internal void AssociarPessoa()
        {
            PessoaId = Pessoa.Id;
        }

        public void Inativar() => Ativo = false;

        public void Ativar() => Ativo = true;

        public bool EhEspecial() =>  DataCadastro < DateTime.Now.AddYears(-2) && Ativo;

        public bool ClienteAtivo() => Ativo;

        public override string ToString() => $"{Pessoa.Cpf} - {Pessoa.Nome}";

        public class FabricaCliente
        {
            public static Cliente Criar(string cpf, string nome, DateTime dataNascimento, bool ativo)
            {
                return new Cliente(cpf, nome, dataNascimento, ativo);
            }
        }

        //public void Validar()
        //{
        //    Validacoes.ValidarSeNulo(PessoaId, "O campo Nome do cliente não pode estar vazio.");           
        //}

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
