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
                Console.Clear();
                Console.WriteLine("----Aqui iremos abrir a sua conta");
            
                Console.WriteLine("Digite o número da agência: ");
                int numeroDaAgencia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número da conta: ");
                int numeroDaConta = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o dinheiro que você quer depositar: ");
                double saldo = double.Parse(Console.ReadLine());
            
                entity.Agencia = numeroDaAgencia;
                entity.NumeroConta = numeroDaConta;
                entity.Saldo = saldo;

                Console.WriteLine($"O número da agência e de sua conta é : { entity.Agencia }-{ entity.NumeroConta }.");
                Console.WriteLine($"Seu saldo é de: {entity.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }.");
                
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