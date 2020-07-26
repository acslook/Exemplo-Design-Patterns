using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public class ComponentesAndroid : ComponentesAbstractFactory
    {
        public override BotaoAbstract CriarBotao(string nome)
        {
            return new BotaoAndroid(nome);
        }
    }
}
