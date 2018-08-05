using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity>
        : IBaseDomainService<TEntity>
        where TEntity : class
    {
        //atributo para acessar o repositorio..
        private readonly IBaseRepository<TEntity> repository;

        //construtor para injeção de dependencia..
        public BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity t)
        {
            repository.Insert(t);
        }

        public virtual void Atualizar(TEntity t)
        {
            repository.Update(t);
        }

        public virtual void Excluir(TEntity t)
        {
            repository.Delete(t);
        }

        public virtual List<TEntity> ConsultarTodos()
        {
            return repository.FindAll();
        }

        public virtual TEntity ConsultarPorId(int id)
        {
            return repository.FindById(id);
        }        

        public virtual void Dispose()
        {
            repository.Dispose();
        }       
    }
}
