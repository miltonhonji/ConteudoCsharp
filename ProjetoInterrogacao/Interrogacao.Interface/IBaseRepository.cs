using System;

namespace ProjetoInterrogacao.Interrogacao.Interface
{
    public interface IBaseRepository<TEntity>
    {
        void Save(T entity);
        void Delete(int id);
        void Update(int id);
        List<TEntity> GetData();         
    }
}