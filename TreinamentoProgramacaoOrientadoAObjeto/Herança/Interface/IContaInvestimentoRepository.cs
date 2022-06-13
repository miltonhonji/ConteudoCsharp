using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe.ContaCorrente;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IContaInvestimentoRepository : IBaseRepository<ContaInvestimento>
    {
        void RegastarTitulo(ContaInvestimento contaInvestimento);
        List<ContaInvestimento> ListarInvestimento();
        List<ContaInvestimento> ListarInvestimentosPorDatas(DateTime dataInicio, DateTime dataFim);
        void Investir(ContaInvestimento contaInvestimento);
    }
}