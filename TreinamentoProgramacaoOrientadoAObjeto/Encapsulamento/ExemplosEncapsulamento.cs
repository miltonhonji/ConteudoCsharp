using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Encapsulamento
{
    public class ExemplosEncapsulamento
    {
        public void Execucao()
        {
            Console.Clear();
            Conta conta = new Conta("Milton Honji");
            conta.Depositar(200);
            conta.Sacar(50);
            Console.WriteLine($"Valor: { conta.ObtemValor() }");
            Console.WriteLine($"Cliente: { conta.ObtemCliente() }");
            Console.ReadLine();
        }

        public void ObterSmartphone()
        {
            var smartphone = new Smartphone();
            smartphone.Ligar();
            smartphone.Desligar();
            smartphone.Testar();
            smartphone.ObterSmartphone();
        }
    }
}