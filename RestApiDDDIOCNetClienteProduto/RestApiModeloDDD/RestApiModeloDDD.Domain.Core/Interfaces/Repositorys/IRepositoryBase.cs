using System.Collections.Generic;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll(); //metodo de busca

        TEntity GetById(int id);
    }
}