using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        //atributo para receber o contexto do EF..
        private readonly DataContext contexto;

        //construtor que será utilizado pelo Simple Injector para
        //"injetar" o espaço de memória do atributo DataContext
        public BaseRepository(DataContext contexto)
        {
            this.contexto = contexto;
        }

        public int Count()
        {
            return contexto.Set<TEntity>().Count();
        }

        public int Count(Func<TEntity, bool> expression)
        {
            return contexto.Set<TEntity>().Count(expression);
        }

        public void Delete(TEntity t)
        {
            contexto.Entry(t).State = EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose(); //fechar o contexto..
        }

        public TEntity Find(Func<TEntity, bool> expression)
        {
            return contexto.Set<TEntity>().FirstOrDefault(expression);
        }

        public List<TEntity> FindAll()
        {
            return contexto.Set<TEntity>().ToList();
        }

        public List<TEntity> FindAll(Func<TEntity, bool> expression)
        {
            return contexto.Set<TEntity>().Where(expression).ToList();
        }

        public TEntity FindById(int id)
        {
            return contexto.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity t)
        {
            contexto.Entry(t).State = EntityState.Added;
            contexto.SaveChanges();
        }

        public void Update(TEntity t)
        {
            contexto.Entry(t).State = EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
