using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFactoryMethod
{
    public abstract class Transmissor
    {
        protected readonly List<string> ComandosExecutados;
        protected Transmissor(string endereco)
        {
            Endereco = endereco;
            ComandosExecutados = new List<string>();
        }

        protected string Endereco { get; set; }

        public abstract void AbrirTransmissao();
        public abstract void FecharTransmissao();
        public abstract void EnviarComando(string comando);
        public string RetornarComandosExecutados()
        {
            return string.Join("\n", ComandosExecutados);
        }
    }
}
