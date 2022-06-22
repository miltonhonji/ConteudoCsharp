using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IContaCorrenteRepository : IBaseRepository<ContaCorrente>
    {
        void Pix(string chave, double valor);
        void Depositar(ContaCorrente contaCorrente);
        List<ContaCorrente> ObterExtratoConta();
    }
}