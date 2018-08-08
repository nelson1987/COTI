namespace Projeto.Domain.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        #region Repositorios

        IEstoqueRepository EstoqueRepository { get; }
        IProdutoRepository ProdutoRepository { get; }

        #endregion
    }
}
