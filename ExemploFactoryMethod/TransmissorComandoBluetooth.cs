using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethod
{
    public class TransmissorComandoBluetooth : Transmissor
    {
        public TransmissorComandoBluetooth(string endereco) : base(endereco)
        {
            Endereco = endereco;
        }

        public override void AbrirTransmissao()
        {
            Console.WriteLine("Transmissão BLUETOOTH aberta.");
        }

        public override void FecharTransmissao()
        {
            Console.WriteLine("Transmissão BLUETOOTH fechada.");
        }

        public override void EnviarComando(string comando)
        {
            ComandosExecutados.Add(comando);
        }
    }
}
