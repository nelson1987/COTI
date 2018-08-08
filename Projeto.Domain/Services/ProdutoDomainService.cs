using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Services
{
    public class ProdutoDomainService
        : BaseDomainService<Produto>, IProdutoDomainService
    {
        //atributo para armazenar o repositorio
        private readonly IProdutoRepository repository;

        //construtor para injeção de dependencia..
        public ProdutoDomainService(IProdutoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
