using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethod
{
    public class TransmissorComandoUSB : Transmissor
    {
        public TransmissorComandoUSB(string endereco) : base(endereco)
        {
            Endereco = endereco;
        }

        public override void AbrirTransmissao()
        {
            Console.WriteLine("Transmissão USB aberta.");
        }

        public override void FecharTransmissao()
        {
            Console.WriteLine("Transmissão USB fechada.");
        }
        public override void EnviarComando(string comando)
        {
            ComandosExecutados.Add(comando);
        }
    }
}
