using System;
using System.Globalization;
using TreinamentoProgramacaoOrientadoAObjeto.Classe;

namespace TreinamentoProgramacaoOrientadoAObjeto.Métodos
{
    public class ExemplosMetodos
    {
        public void Execucao()
        {
            Console.Clear();
            Menu();
        }

        public void Menu()
        {
            decimal valor = 0m;
            Classe.Conta conta = new Classe.Conta();

            Console.Clear();
            Console.WriteLine("Bem vindo ao Banco dos Devs");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sair"); 

            Console.WriteLine("O que você deseja fazer?: ");
            int opcaoTipoOperacao = int.Parse(Console.ReadLine());

            switch (opcaoTipoOperacao)
            {
                case 1: Depositar(valor); break;
                case 2: Sacar(valor); break;
                case 3: Transferir(valor, conta); break;
                case 4: Environment.Exit(0); break;
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

                Console.WriteLine("Insira o valor para depósito: ");
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
                    Console.WriteLine("Não foi possível efetuar o método.");
                }                            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        public void Transferir(decimal valorTransferir, Conta contaDestino)
        {
            Classe.Conta contaPrincipal = new Classe.Conta();
            Console.Clear();
            Console.WriteLine(" --- Transferir dinheiro para outra conta --- ");
            Console.WriteLine();
            Console.WriteLine("Insira um valor: ");
            valorTransferir = int.Parse(Console.ReadLine());
            contaPrincipal.Saldo = 1200m;

            if(valorTransferir > contaPrincipal.Saldo)
            {
                Console.WriteLine("Não foi possível efetuar a transferência.");
            }
            else 
            {
                contaPrincipal.Saldo -= valorTransferir;
                Console.WriteLine($"O valor da Conta Principal agora está com { contaPrincipal.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais.");
                contaDestino.Saldo += valorTransferir;
                Console.WriteLine($"O valor da Conta Destino agora está com { contaDestino.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) } reais.");
            }          
        }
    }
}