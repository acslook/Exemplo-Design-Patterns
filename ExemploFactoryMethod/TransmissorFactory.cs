using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethod
{
    public abstract class TransmissorFactory
    {
        public abstract Transmissor CriarTransmissorComando(string endereco);

        public static TransmissorFactory Transmissor(TipoTransmissao tipoTransmissao)
        {
            if (tipoTransmissao == TipoTransmissao.Bluetooth)
                return new TransmissorBluetoothFactory();
            if (tipoTransmissao == TipoTransmissao.USB)
                return new TransmissorUSBFactory();

            throw new ApplicationException("Tipo de comunicação inválido.");
        }
    }
}
