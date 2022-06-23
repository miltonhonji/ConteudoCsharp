using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ExemplosHeranca
    {
        public void Execucao()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo ao banco XPTO");
                Console.WriteLine();

                Console.WriteLine("Escolha um tipo de serviço desejado: ");
                Console.WriteLine("1 - Conta Corrente");
                Console.WriteLine("2 - Conta Poupança");
                Console.WriteLine("3 - Conta Investimento");
                int tipoConta = int.Parse(Console.ReadLine());

                switch (tipoConta)
                {
                    case 1: EscolherOpcoesDaContaCorrente(); break;
                    //case 1: contaCorrenteRepository.Save(contaCorrente); break;
                }                   
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            
        public void EscolherOpcoesDaContaCorrente()
        {
            var contaCorrenteRepository = new ContaCorrenteRepository();
            var contaCorrente = new ContaCorrente();

            Console.Clear();
            Console.WriteLine("Banco dos Dev´s - Conta Corrente");
        }
    }
}