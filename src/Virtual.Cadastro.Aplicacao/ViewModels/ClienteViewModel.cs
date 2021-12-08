using System;

namespace Virtual.Cadastro.Aplicacao.ViewModels
{
    public class ClienteViewModel
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}
