using System;
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
                int numeroAgencia = int.Parse(Console.ReadLine());

                
            
                entity.Agencia = numeroAgencia;

                Console.WriteLine($"O número da agência é: { entity.Agencia }.");
            }
            catch (System.Exception ex)
            {
                 // TODO
            }

        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        } 
    }
} 