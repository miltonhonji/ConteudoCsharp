using System;
using System.Globalization;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

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
                case 2: Sacar(valor); break;
            }                
        }

        public void Depositar(decimal valorDepositado)
        {
            Classe.Cliente cliente = new Classe.Cliente();
            Classe.Conta conta = new Classe.Conta();
            try
            {
                Console.Clear();
                Console.WriteLine($"--- Você está na Tela de Depósito --- \r\n");
                Console.WriteLine("Insira o seu nome: ");
                string nomeDoCliente = Console.ReadLine() + "\r\n";

                cliente.Nome = nomeDoCliente;
                conta.Saldo = 1200m;

                Console.WriteLine($"Seja bem vindo { cliente.Nome }");
                Console.WriteLine($"Seu saldo atual é de: { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} \r\n");

                Console.WriteLine("Insira o valor para depósito");
                valorDepositado = decimal.Parse(Console.ReadLine());

                conta.Saldo += valorDepositado;

                Console.WriteLine($"Você depositou: { valorDepositado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais, agora o seu saldo é de: { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais ");
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.InnerException);
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("Ops, algo deu errado!");
            }
        }

        public void Sacar(decimal valorSacado)
        {
            Classe.Cliente cliente = new Classe.Cliente();
            Classe.Conta conta = new Classe.Conta();

            try
            {
                Console.Clear();
                Console.WriteLine($"--- Você está na Tela de Saque --- \r\n");
                
                Console.WriteLine("Insira o seu nome: ");
                string nomeDoCliente = Console.ReadLine() + "\r\n";

                cliente.Nome = nomeDoCliente;
                conta.Saldo = 1200m;

                Console.WriteLine($"Seja bem vindo { cliente.Nome }");
                Console.WriteLine($"Seu saldo atual é de: { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} \r\n");

                Console.WriteLine("Insira um valor para saque: ");
                valorSacado = decimal.Parse(Console.ReadLine());

                if(valorSacado < conta.Saldo)
                {
                    conta.Saldo -= valorSacado;
                    Console.WriteLine($"O valor sacado foi de { valorSacado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais, agora o seu saldo é de { conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais ");
                }
                else if (valorSacado > conta.Saldo)
                {
                    Console.WriteLine("Não possível efetuar o método.");
                }
                    
                    
            }
            catch (System.Exception ex)
            {
                 // TODO
            }
        }
    }
}