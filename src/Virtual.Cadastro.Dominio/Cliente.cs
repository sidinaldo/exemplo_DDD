using System;
using Virtual.Core.ObjetosDominio;

namespace Virtual.Cadastro.Dominio
{
    public class Cliente : EntidadeBase
    {      
        public bool Ativo { get; set; }
        public Guid PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        protected Cliente() { }

        public Cliente(Guid pessoaId)
        {
            Id = Guid.NewGuid();
            PessoaId = Pessoa.Id;
            Ativo = true;           

        }

        internal void AssociarPessoa(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }

        public void InativarCliente()
        {
            Ativo = false;
        }

        public void AtivarCliente()
        {
            Ativo = true;
        }

        public bool ClienteAtivo => Ativo;

        public override string ToString()
        {
            return $"{Pessoa.Cpf} - {Pessoa.Nome}";
        }

        public class FabricaCliente
        {
            public static Cliente Criar(Guid pessoaId)
            {
                return new Cliente(pessoaId);
            }
        }

        public void Validar()
        {
            Validacoes.ValidarSeNulo(PessoaId, "O campo Nome do cliente não pode estar vazio.");            
        }
    }
}
