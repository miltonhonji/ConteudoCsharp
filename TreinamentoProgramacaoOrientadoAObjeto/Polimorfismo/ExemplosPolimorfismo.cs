using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Polimorfismo
{
    public class ExemplosPolimorfismo
    {
        public void Execucao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o segundo número: ");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o terceiro valor: ");
            var numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            var primeiraSoma = Somar(numero1, numero2);
            var segundaSoma = Somar(numero1, numero2, numero3);
            var terceiraSoma = Somar(true);

            Console.WriteLine($" Primeira Soma: { primeiraSoma }.");
            Console.WriteLine($" Segunda Soma: { segundaSoma }.");
            Console.WriteLine($" Terceira Soma: { terceiraSoma }.");
            Console.ReadKey();
        }

        public int Somar(int numeroUm, int numeroDois)
        {
            var result = numeroUm + numeroDois;

            return result;
        }

        public int Somar(int numeroUm, int numeroDois, int numeroTres)
        {
            var result = numeroUm + numeroDois + numeroTres;

            CalcularAlgumaCoisa();

            return result; 
        }

        public int Somar(bool verifica)
        {
            return 1;
        }

        public void CalcularAlgumaCoisa()
        {

        }
    }
}