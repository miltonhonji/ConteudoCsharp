using TreinamentoProgramacaoOrientadoAObjeto.Classe;
using System;
using System.Globalization;

namespace TreinamentoProgramacaoOrientadoAObjeto.Métodos
{
    public class ExemplosMetodos
    {
        public decimal valor;

        public void Execucao()
        {
            Console.Clear();
            Menu();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo aos banco dos Devs");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sair"); 

            Console.WriteLine("O que você deseja fazer: ");
            int opcaoDeposito = int.Parse(Console.ReadLine());

            switch (opcaoDeposito)
            {
                case 1: Depositar(valor); break;
            }                
        }

        public void Depositar(decimal valorDepositado)
        {
            Console.Clear();

            try
            {
                Classe.Cliente cliente = new Classe.Cliente();
                Classe.Conta conta = new Classe.Conta();

                Console.WriteLine("Insira o seu nome: ");
                string nomeDoCliente = Console.ReadLine();

                cliente.Nome = nomeDoCliente;
                conta.Saldo = 1200m;

                Console.WriteLine($"Seja bem vindo { cliente.Nome }.");
                Console.WriteLine($"Seu saldo atual é de: { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} \r\n");

                Console.WriteLine("Insira o valor para depósito");
                valorDigitado = decimal.Parse(Console.ReadLine());

                conta.Saldo += valorDepositado;

                Console.WriteLine($"Você depositou: { valorDepositado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }, o seu saldo agora é { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } ");

                //return valorDigitado;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Não há nada escrito nos campos!");
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.InnerException);
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Ops, algo deu errado!");
            }
        }
    }
}