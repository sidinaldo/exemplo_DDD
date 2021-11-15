using System;

namespace Virtual.Core.ObjetosDominio
{
    public class ExcecaoDominio : Exception
    {
        public ExcecaoDominio()
        {
        }

        public ExcecaoDominio(string mesagem) : base(mesagem)
        {
        }

        public ExcecaoDominio(string mesagem, Exception excecaoInterna) : base(mesagem, excecaoInterna)
        {
        }
    }
}
