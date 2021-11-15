using System;
using Virtual.Core.ObjetosDominio;

namespace Virtual.Cadastro.Dominio
{
    public class Empresa : EntidadeBase
    {
        public Guid ClienteId { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
