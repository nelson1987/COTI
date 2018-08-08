using System;
using System.Collections.Generic;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Insert(TEntity t);

        void Update(TEntity t);

        void Delete(TEntity t);

        List<TEntity> FindAll();

        List<TEntity> FindAll(Func<TEntity, bool> expression);

        TEntity Find(Func<TEntity, bool> expression);

        TEntity FindById(int id);

        int Count();

        int Count(Func<TEntity, bool> expression);
    }
}
