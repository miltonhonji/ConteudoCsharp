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
                
                entity.Agencia = 1803;
                entity.NumeroConta = 110786;

                Console.WriteLine("--- Vamos abrir a sua conta ? ---");        

                Console.WriteLine("Digite o dinheiro que você quer depositar: ");
                double saldo = double.Parse(Console.ReadLine());
                            
                entity.Saldo = saldo;

                Console.WriteLine($"A sua nova conta é: { entity.Agencia } - { entity.NumeroConta }.");
                Console.WriteLine($"Agora o seu saldo é de: { entity.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) }.");                
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