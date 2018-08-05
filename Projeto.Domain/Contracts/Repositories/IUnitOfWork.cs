using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
