using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ExemplosHeranca
    {
        public void Execucao()
        {
            var contaCorrenteRepository = new ContaCorrenteRepository();
            var contaInvestimentoRepository = new ContaInvestimentoRepository();

            var contaCorrente = new ContaCorrente();
            var contaInvestimento = new ContaInvestimento();

            try
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo ao banco XPTO");
                Console.WriteLine();

                Console.WriteLine("Escolha um tipo de serviço desejado: ");
                Console.WriteLine();
                Console.WriteLine("1 - Conta Corrente");
                Console.WriteLine("2 - Conta Poupança");
                Console.WriteLine("3 - Conta Investimento");
                int tipoConta = int.Parse(Console.ReadLine());

                /*switch (tipoConta)
                {
                    case 1: contaCorrenteRepository.Save(contaCorrente); break;
                    default:
                        break;
                }*/
                      
                //contaCorrenteRepository.Save(contaCorrente);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}