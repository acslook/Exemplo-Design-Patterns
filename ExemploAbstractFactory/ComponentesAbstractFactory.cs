using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    public abstract class ComponentesAbstractFactory
    {
        public abstract BotaoAbstract CriarBotao(string nome);

        public static ComponentesAbstractFactory ObterInstanciaComponentes(TipoSistema tipoSistema)
        {
            switch (tipoSistema)
            {
                case TipoSistema.Android:
                    return new ComponentesAndroid();                    
                case TipoSistema.IOS:
                    return new ComponentesIOS();
                default:
                    throw new ApplicationException("Tipo de sistema inválido.");
            }
        }
    }

    public enum TipoSistema
    {
        Android,
        IOS
    }
}
