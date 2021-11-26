using System;
using Virtual.Core.ObjetosDominio;
using Virtual.Core.Utils;

namespace Virtual.Cadastro.Dominio.Entidades
{
    public class   Pessoa: EntidadeBase
    {
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        protected Pessoa() {}

        public Pessoa(string cpf, string nome, DateTime dataNascimento)
        {
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;

            Validar();
        }

        public virtual void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do cliente não pode estar vazio.");
            Validacoes.ValidarTamanho(Nome, 10, 100, "O campo Nome do cliente não pode ser menor que 10 caractéres e maior que 100.");
            Validacoes.ValidarSeVazio(Cpf, "O campo CPF do cliente não pode estar vazio.");
            Validacoes.ValidarSeFalso(ValidarCpf.ValidarCPF(Cpf), "O CPF é inválido.");
        }
    }
}
