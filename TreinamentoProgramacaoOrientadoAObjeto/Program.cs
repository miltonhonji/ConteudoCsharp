using TreinamentoProgramacaoOrientadoAObjeto.Objetos;
using TreinamentoProgramacaoOrientadoAObjeto.Métodos;
using TreinamentoProgramacaoOrientadoAObjeto.Abstração;
using TreinamentoProgramacaoOrientadoAObjeto.Encapsulamento;
using TreinamentoProgramacaoOrientadoAObjeto.Herança;
using TreinamentoProgramacaoOrientadoAObjeto.Polimorfismo;
using System;

namespace TreinamentoProgramacaoOrientadoAObjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Menu();
            //Exemplos Abstração
            var abstracao = new Abstração.Abstracao();

            abstracao.Execucao();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("** Programação Orientado a Objetos - Carreira Única **");
            Console.WriteLine("--------------------------");
            Console.WriteLine("0 - Classes e Objetos");
            Console.WriteLine("1 - Métodos");
            Console.WriteLine("2 - Herança - Interface e Implementação");
            Console.WriteLine("3 - Abstração");
            Console.WriteLine("4 - Encapsulamento");
            Console.WriteLine("5 - Polimorfismo");
            Console.WriteLine("6 - Métodos - Cliente/Produtos");
            Console.WriteLine("7 - Sair da Aplicação");
            Console.WriteLine();
            
            Console.WriteLine("Escolha uma opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 0: new Objetos.ExemplosClassesEObjetos().Execucao(); break;
                case 1: new Métodos.ExemplosMetodos().Execucao(); break;
                case 2: new Herança.ExemplosHeranca().Execucao(); break;
                case 3: new Abstracao.Execucao(); break;
                case 4: new Encapsulamento.ExemplosEncapsulamento().Execucao(); break;
                case 5: new Polimorfismo.ExemplosPolimorfismo().Execucao(); break;
                case 6: new Métodos.ExemplosMetodosClienteProduto().Execucao(); break;
                case 7: Environment.Exit(0); break;
                //default:
                    //break;
            }
            Console.ReadKey();
        }
    }
}
