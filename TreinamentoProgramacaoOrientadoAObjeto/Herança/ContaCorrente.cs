using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class Conta
    {
        public int Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public string Banco { get; set;}
        public string Nome { get; set; }
        public string Cpf { get;set; }
    }

    public class ContaCorrente : Conta
    {
        public ETipoConta TipoConta { get; set; }
        public int CodigoBanco {get; set;}
    }

    public class ContaPoupanca : Conta
    {
        public ETipoConta TipoConta { get; set;}
        public DateTime DataDePoupar { get; set; }
    }

    public class ContaInvestimento : Conta
    {
        public string TipoInvestidor { get; set; }
        public string TipoInvestimento { get; set; }
        public ETipoConta TipoConta { get; set; }
    }

    public enum ETipoConta
    {
        ContaCorrente = 1,
        ContaPoupanca = 2,
        ContaInvestimento = 3
    }

    public enum EChavePix
    {
        CPF = 1,
        Celular = 2,
        Email = 3
    }
}