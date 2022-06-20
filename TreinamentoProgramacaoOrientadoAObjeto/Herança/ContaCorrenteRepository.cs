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
            ContaCorrente contaDestino = new ContaCorrente();
            
            try
            {
                Console.Clear();
                
                entity.Agencia = 1803;
                entity.NumeroConta = 110786;
                entity.Saldo = 16000f;

                Console.WriteLine("Digite o dinheiro que você quer depositar: ");
                double saldo = double.Parse(Console.ReadLine());
                            
                entity.Saldo -= saldo;
                Console.Clear();  

                Console.WriteLine("--- Dados do Cliente que irá receber: ---");
                Console.WriteLine();
                Console.WriteLine("Digite o número da Agência: ");
                int numeroDaAgencia = int.Parse(Console.ReadLine())
                Console.WriteLine("Digite o número da conta de destino: ");
                int numeroContaDestino = int.Parse(Console.ReadLine());
                


                //Console.WriteLine($"Agora o seu saldo é de: { entity.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }.");              
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