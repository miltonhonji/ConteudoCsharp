using TreinamentoProgramacaoOrientadoAObjeto.Classe;
using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Métodos
{
    public class ExemplosMetodos
    {
        //public Decimal valor;

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
                case 1: 
                    ObterInformacoes();
                    //Depositar(valor); 
                break;
            }                
        }

        public void ObterInformacoesCliente()
        {
            try
            {
                Classe.Cliente cliente = new Classe.Cliente();
                Classe.Conta conta = new Classe.Conta();

                Console.WriteLine("Insira o seu nome: ");
                string nomeDoCliente = Console.ReadLine();

                cliente.Nome = nomeDoCliente;
                conta.Saldo = "1200m";

                Console.WriteLine($"Seja bem vindo  { cliente.Nome } ");
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

        /*public Decimal Depositar(Decimal valorDigitado)
        {
            Console.WriteLine("Insira o valor para depósito");
            valorDigitado = decimal.Parse(Console.ReadLine());

            retrun valorDigitado;
        }*/
    }
}