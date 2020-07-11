using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethod
{
    public class TransmissorBluetoothFactory : TransmissorFactory
    {
        public override Transmissor CriarTransmissorComando(string endereco)
        {
            return new TransmissorComandoBluetooth(endereco);
        }
    }
}
