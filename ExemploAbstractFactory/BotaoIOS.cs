using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public class BotaoIOS : BotaoAbstract
    {
        public BotaoIOS(string nome)
            : base(nome)
        {
            Console.WriteLine($"Criado botão IOS => { nome }");
        }
    }
}
