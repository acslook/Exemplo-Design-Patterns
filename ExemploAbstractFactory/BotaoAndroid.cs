using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public class BotaoAndroid : BotaoAbstract
    {
        public BotaoAndroid(string nome)
            :base(nome)
        {
            Console.WriteLine($"Criado botão Android => { nome }");
        }
    }
}
