using System;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IContaCorrenteRepository : IBaseRepository<ContaCorrente>
    {
        void Pix(string chave, double valor);
        List<ContaCorrente> ObterExtratoConta();
    }
}