using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Encapsulamento
{
    public class Smartphone : Eletronico
    {
        private static void ObterModeloAndroid(){}

        private static void ObterModeloIOS(){}

        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }
        
        pubblic void ObterSmartphone()
        {
            ObterModeloAndroid();
            ObterModeloIOS();
        }
    }
}