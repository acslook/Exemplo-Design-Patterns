using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public class ComponentesIOS : ComponentesAbstractFactory
    {
        public override BotaoAbstract CriarBotao(string nome)
        {
            return new BotaoIOS(nome);
        }
    }
}
