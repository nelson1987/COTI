using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Services
{
    public class EstoqueDomainService
        : BaseDomainService<Estoque>, IEstoqueDomainService
    {
        //atributo do repositorio..
        private readonly IEstoqueRepository repository;

        //construtor para injeção de dependencia..
        public EstoqueDomainService(IEstoqueRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
