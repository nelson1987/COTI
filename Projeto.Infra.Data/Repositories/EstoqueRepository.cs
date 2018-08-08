using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class EstoqueRepository
        : BaseRepository<Estoque>, IEstoqueRepository
    {
        //atributo para armazenar o contexto..
        private readonly DataContext contexto;

        //construtor para injeção de dependencia..
        public EstoqueRepository(DataContext contexto)
            : base(contexto)
        {
            this.contexto = contexto;
        }       
    }
}
