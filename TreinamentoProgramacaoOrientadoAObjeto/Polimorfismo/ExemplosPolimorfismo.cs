using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Polimorfismo
{
    public class ExemplosPolimorfismo
    {
        public void Execucao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            var numeroUm = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo valor: ");
            var numeroDois = int.Parse(Console.ReadLine());
        }

        public int Somar(int numeroUm, int numeroDois)
        {
            var result = numeroUm + numeroDois;

            return result;
        }
    }
}