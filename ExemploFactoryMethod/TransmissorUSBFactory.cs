using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethod
{
    public class TransmissorUSBFactory : TransmissorFactory
    {
        public override Transmissor CriarTransmissorComando(string endereco)
        {
            return new TransmissorComandoUSB(endereco);
        }
    }
}
