using System;
using Virtual.Core.ObjetosDominio;

namespace Virtual.Cadastro.Dominio
{
    public class Cliente : EntidadeBase
    {
        public Guid ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }


        public void AtualizarCliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"{Cpf} - {Nome}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do cliente não pode estar vazio.");
            Validacoes.ValidarTamanho(Nome, 10, 100, "O campo Nome do cliente não pode ser menor que 10 caractéres e maior que 100.");
            Validacoes.ValidarSeVazio(Cpf, "O campo Nome do cliente não pode estar vazio.");
            Validacoes.ValidarSeVerdadeiro(true, "O CPF é inválido.");
        }


    }
}
