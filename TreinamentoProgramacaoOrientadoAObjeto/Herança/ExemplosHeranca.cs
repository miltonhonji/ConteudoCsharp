using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ExemplosHeranca
    {
        public void Execucao()
        {
            Console.Clear();
            var contaCorrenteRepository = new ContaCorrenteRepository();
            var contaCorrente = new ContaCorrente();

            try
            {
                Console.WriteLine("Seja bem vindo ao banco XPTO");
                Console.WriteLine();

                Console.WriteLine("Escolha um tipo de serviço desejado: ");
                Console.WriteLine();

                contaCorrenteRepository.Save(contaCorrente);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}