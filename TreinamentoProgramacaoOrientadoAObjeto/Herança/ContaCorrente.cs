using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get;set; }
        public double Saldo { get; set; }
        public string Banco { get; set;}
    }

    public class ContaCorrente : Conta
    {

    }
    public enum ETipoConta
    {
        ContaCorrente = 1,
        ContaPoupanca = 2,
        ContaInvestimento = 3
    }
}