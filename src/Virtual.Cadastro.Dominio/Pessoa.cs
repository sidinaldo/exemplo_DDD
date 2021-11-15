﻿using System;
using Virtual.Core.ObjetosDominio;
using Virtual.Core.Utils;

namespace Virtual.Cadastro.Dominio
{
    public class Pessoa: EntidadeBase, IAgregadorRaiz
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        public Pessoa(string cpf, string nome, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do cliente não pode estar vazio.");
            Validacoes.ValidarTamanho(Nome, 10, 100, "O campo Nome do cliente não pode ser menor que 10 caractéres e maior que 100.");
            Validacoes.ValidarSeVazio(Cpf, "O campo Nome do cliente não pode estar vazio.");
            Validacoes.ValidarSeFalso(ValidarCpf.ValidarCPF(Cpf), "O CPF é inválido.");
        }
    }
}
