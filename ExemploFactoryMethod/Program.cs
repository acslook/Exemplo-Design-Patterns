using System;

namespace ExemploFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var transmissorBluetooth = TransmissorFactory.Transmissor(TipoTransmissao.Bluetooth)
                                        .CriarTransmissorComando("endereco:porta");

            transmissorBluetooth.AbrirTransmissao();

            transmissorBluetooth.EnviarComando("Comando BL1");
            transmissorBluetooth.EnviarComando("Comando BL2");            

            Console.WriteLine($"Comandos enviados por BLUETOOTH:\n{transmissorBluetooth.RetornarComandosExecutados()}");
            transmissorBluetooth.FecharTransmissao();

            Console.WriteLine("\n\n=================================\n\n");

            var transmissorUSB = TransmissorFactory.Transmissor(TipoTransmissao.USB)
                                    .CriarTransmissorComando("endereco:porta");

            transmissorUSB.AbrirTransmissao();

            transmissorUSB.EnviarComando("Comando US1");
            transmissorUSB.EnviarComando("Comando US2");
            transmissorUSB.EnviarComando("Comando US3");            

            Console.WriteLine($"Comandos enviados por USB:\n{transmissorUSB.RetornarComandosExecutados()}");
            transmissorUSB.FecharTransmissao();
        }
    }
}
