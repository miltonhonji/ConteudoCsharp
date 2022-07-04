using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Encapsulamento
{
    public class Eletronico
    {
        private readonly string _nome;
        private readonly string _marca;
        private readonly string _tipo;

        public string algumaCoisa { get; set; }
        
        public Eletronico(string nome, string marca, string tipo)
        {
            _nome  = nome;
            _marca = marca;
            _tipo = tipo;
        }

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual void Testar()
        {
            //Teste de equipamento
        }
    }
}