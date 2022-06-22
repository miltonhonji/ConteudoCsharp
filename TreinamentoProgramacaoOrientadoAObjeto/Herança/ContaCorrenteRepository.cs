using System;
using System.Globalization;
using TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Depositar(ContaCorrente contaCorrente)
        {
            throw new NotImplementedException();
        }

        public List<ContaCorrente> ObterExtratoConta()
        {
            throw new NotImplementedException();
        }

        public void Pix(string chave, double valor)
        {
            throw new NotImplementedException();
        }

        public void Save(ContaCorrente entity)
        {
            try
            {                
                entity.Agencia = 2206;
                entity.NumeroConta = "180386-6";
                entity.Banco = "Banco dos Devs";
                entity.CodigoBanco = 17;

                Console.Clear();            
                Console.WriteLine("--- Banco dos Dev's - Vamos abrir a sua conta? ---");
                Console.WriteLine();
                Console.WriteLine("Insira o seu nome: ");
                string nome = Console.ReadLine();
            
                Console.WriteLine("Insira o seu Cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Por fim, deseja depositar dinheiro na conta: ");
                double saldo = double.Parse(Console.ReadLine());

                entity.Nome = nome;
                entity.Cpf = cpf;
                entity.Saldo = saldo;

                Console.Clear();
                Console.WriteLine("Cadastro efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine($"Nome: { entity.Nome }, CPF: { entity.Cpf } ");
                Console.WriteLine($"O Código da Agência é: { entity.CodigoBanco }");
                Console.WriteLine($"O Número da Agência é: { entity.Agencia } ");
                Console.WriteLine($"O Número da Conta é: { entity.NumeroConta } ");
                Console.WriteLine($"Saldo inicial é de: {entity.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
                Console.ReadKey();            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        } 
    }
} 