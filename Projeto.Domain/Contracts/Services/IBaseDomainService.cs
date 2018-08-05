using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity> : IDisposable
        where TEntity : class
    {
        void Cadastrar(TEntity t);

        void Atualizar(TEntity t);

        void Excluir(TEntity t);

        List<TEntity> ConsultarTodos();

        TEntity ConsultarPorId(int id);
    }
}
