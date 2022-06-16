using System;
using TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ContaInvestimentoRepository : IContaInvestimentoRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Investir (ContaInvestimento contaInvestimento)
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ListarInvestimento()
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ListarInvestimentosPorDatas(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public void RegastarTitulo(ContaInvestimento contaInvestimento)
        {
            throw new NotImplementedException();
        }

        public void Save(ContaInvestimento entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}