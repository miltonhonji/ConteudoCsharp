using System;
using TreinamentoProgramacaoOrientadoAObjeto.Herança;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface
{
    public interface IBaseRepository <TEntity>
    {
        void Save(TEntity entity);
        void Update(int id);
        void Delete(int id);
    }
}