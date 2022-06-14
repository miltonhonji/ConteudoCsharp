using System;
using TreinamentoProgramacaoOrientadoAObjeto.Classe.ContaCorrente;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IBaseRepository <TEntity>
    {
        void Save(T entity);
        void Update(int id);
        void Delete(int id);
    }
}