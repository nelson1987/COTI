using System.Data.Entity;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //atributo para armazenar o contexto..
        private readonly DataContext contexto;
        //atributo para armazenar a transação..
        private DbContextTransaction transaction;
        //construtor para injeção de dependencia..
        public UnitOfWork(DataContext contexto)
        {
            this.contexto = contexto;
        }

        public IEstoqueRepository EstoqueRepository
        {
            get { return new EstoqueRepository(contexto); }
        }

        public IProdutoRepository ProdutoRepository
        {
            get { return new ProdutoRepository(contexto); }
        }

        public void BeginTransaction()
        {
            transaction = contexto.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
    }
}