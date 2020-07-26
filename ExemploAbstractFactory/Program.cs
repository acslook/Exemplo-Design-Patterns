using System;

namespace ExemploAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var componentesAndroid = ComponentesAbstractFactory.ObterInstanciaComponentes(TipoSistema.Android);
            BotaoAbstract botaoA = componentesAndroid.CriarBotao("BotaoA");
            BotaoAbstract botaoB = componentesAndroid.CriarBotao("BotaoB");


            var componentesIOS = ComponentesAbstractFactory.ObterInstanciaComponentes(TipoSistema.IOS);
            BotaoAbstract botao1 = componentesIOS.CriarBotao("Botao1");
            BotaoAbstract botao2 = componentesIOS.CriarBotao("Botao2");
        }
    }
}
