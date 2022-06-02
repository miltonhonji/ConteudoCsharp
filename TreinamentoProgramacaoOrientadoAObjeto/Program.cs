using TreinamentoProgramacaoOrientadoAObjeto.Objetos;
using TreinamentoProgramacaoOrientadoAObjeto.Métodos;
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
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("** Programação Orientado a Objetos - Carreira Única **");
            Console.WriteLine("--------------------------");
            Console.WriteLine("0 - Classes e Objetos");
            Console.WriteLine("1 - Métodos");
            Console.WriteLine("2 - Encapsulamento");
            Console.WriteLine("3 - Herança - Interface e Implementação");
            Console.WriteLine("4 - Polimorfismo");
            Console.WriteLine("5 - Métodos - Cliente/Produtos");
            Console.WriteLine("6 - Sair da Aplicação");
            Console.WriteLine();
            
            Console.WriteLine("Escolha uma opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 0: new Objetos.ExemplosClassesEObjetos().Execucao(); break;
                case 1: new Métodos.ExemplosMetodos().Execucao(); break;
                case 2: new Encapsulamento.ExemplosEncapsulamento().Execucao(); break;
                case 3: new Herança.ExemplosHeranca().Execucao(); break;
                case 4: new Polimorfismo.ExemplosPolimorfismo().Execucao(); break;
                case 5: new Métodos.ExemplosMetodosClienteProduto().Execucao(); break;
                case 6: Environment.Exit(0); break;
                //default:
                    //break;
            }
            Console.ReadKey();
        }
    }
}
