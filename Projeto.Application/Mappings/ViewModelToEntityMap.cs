using AutoMapper;
using Projeto.Application.ViewModels.Estoques;
using Projeto.Application.ViewModels.Produtos;
using Projeto.Domain.Entities;

namespace Projeto.Application.Mappings
{
    public class ViewModelToEntityMap : Profile
    {
        //construtor
        public ViewModelToEntityMap()
        {
            CreateMap<EstoqueCadastroViewModel, Estoque>();
            CreateMap<EstoqueEdicaoViewModel, Estoque>();

            CreateMap<ProdutoCadastroViewModel, Produto>();
            CreateMap<ProdutoEdicaoViewModel, Produto>();
        }
    }
}
