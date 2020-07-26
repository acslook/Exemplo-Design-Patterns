using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public abstract class BotaoAbstract
    {       
        public string Nome { get; set; }
        public string Texto { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public BotaoAbstract(string nome)
        {
            Nome = nome;
        }
    }
}
