using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe.ContaCorrente;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IContaCorrenteRepository
    {
         void Save(ContaCorrente contaCorrente);
         void Update(int id);
         void Delete(int id);
    }
}