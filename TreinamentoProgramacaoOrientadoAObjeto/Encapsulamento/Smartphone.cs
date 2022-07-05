using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Encapsulamento
{
    public class Smartphone : Eletronico
    {
        public Smartphone(string nome, string marca, string tipo) : base(nome, marca, tipo)
        {
        }

        public Smartphone() : base("GALAXY", "Samsung", "celular")
        {

        }

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
        
        public void ObterSmartphone()
        {
            ObterModeloAndroid();
            ObterModeloIOS();
        }
    }
}