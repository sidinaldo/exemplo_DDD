using System;
using Virtual.Core.ObjetosDominio;

namespace Virtual.Cadastro.Dominio
{
    public class Empresa : EntidadeBase
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

        public Empresa(string cnpj, string nome, bool ativo = true)
        {
            Cnpj = cnpj;
            Nome = nome;
            Ativo = ativo;

            Validar();
        }

        public virtual void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do fornecedor não pode estar vazio.");
            Validacoes.ValidarTamanho(Nome, 10, 120, "O campo Nome do fornecedor não pode ser menor que 10 caractéres e maior que 120.");
            Validacoes.ValidarSeVazio(Email, "O campo email do fornecedor não pode estar vazio.");
            Validacoes.ValidarSeVazio(Telefone, "O campo telefone do fornecedor não pode estar vazio.");
        }
    }    
}
