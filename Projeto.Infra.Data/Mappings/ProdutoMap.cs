using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("TB_PRODUTO");

            HasKey(p => p.IdProduto);

            Property(p => p.IdProduto)
                .HasColumnName("IDT_PRODUTO");

            Property(p => p.Nome)
                .HasColumnName("NOM_PRODUTO")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Preco)
                .HasColumnName("VLR_PRODUTO")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(p => p.Quantidade)
                .HasColumnName("NUM_PRODUTO")
                .IsRequired();

            HasRequired(p => p.Estoque)
                .WithMany(e => e.Produtos)
                .HasForeignKey(p => p.IdEstoque);
        }
    }
}
