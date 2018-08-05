using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Projeto.Application.ViewModels.Estoques;
using Projeto.Application.ViewModels.Produtos;
using Projeto.Domain.Entities;

namespace Projeto.Application.Mappings
{
    public class EntityToViewModelMap : Profile
    {
        public EntityToViewModelMap()
        {
            CreateMap<Estoque, EstoqueConsultaViewModel>()
                .ForMember(dest => dest.QuantidadeDeProdutos,
                            src => src.MapFrom(e => e.Produtos
                                                .Sum(p => p.Quantidade)));

            CreateMap<Produto, ProdutoConsultaViewModel>()
                .ForMember(dest => dest.Total,
                            src => src.MapFrom(p => p.Preco * p.Quantidade))
                .AfterMap(((src, dest) => 
                    dest.Estoque = new EstoqueConsultaViewModel
                    {
                        IdEstoque = src.Estoque.IdEstoque,
                        Nome = src.Estoque.Nome,
                        QuantidadeDeProdutos = src.Estoque.Produtos
                                                .Sum(p => p.Quantidade)
                    }));
        }
    }
}
