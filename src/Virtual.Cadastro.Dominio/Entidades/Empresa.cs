using System;
using Virtual.Core.ObjetosDominio;
using Virtual.Core.Utils;

namespace Virtual.Cadastro.Dominio.Entidades
{
    public class Empresa : EntidadeBase
    {
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Empresa(string cnpj, string nome, string telefone, bool ativo = true)
        {
            Cnpj = cnpj;
            Nome = nome;
            Ativo = ativo;
            Telefone = telefone;
            DataCadastro = DateTime.Now;

            Validar();
        }

        public void EditarTelefone(string telefone)
        {
            Telefone = telefone;

            Validar();
        }

        public void SetarEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ExcecaoDominio("O campo email do fornecedor não pode estar vazio.");
            }

            Email = email;
        }

        public void EditarEmail(string email)
        {
            Email = email;
        }

        public virtual void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do fornecedor não pode estar vazio.");
            Validacoes.ValidarTamanho(Nome, 10, 120, "O campo Nome do fornecedor não pode ser menor que 10 caractéres e maior que 120.");
            Validacoes.ValidarSeVazio(Telefone, "O campo telefone do fornecedor não pode estar vazio.");
            Validacoes.ValidarSeFalso(ValidarCnpj.ValidarCNPJ(Cnpj), "O CNPJ é inválido.");
        }
    }    
}
