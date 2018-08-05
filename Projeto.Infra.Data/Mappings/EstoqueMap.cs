using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Mappings
{
	public class EstoqueMap : EntityTypeConfiguration<Estoque>
	{
		public EstoqueMap()
		{
			ToTable("TB_ESTOQUE");

			HasKey(e => e.IdEstoque);

			Property(e => e.IdEstoque)
				.HasColumnName("IDT_ESTOQUE");

			Property(e => e.Nome)
				.HasColumnName("NOM_ESTOQUE")
				.HasMaxLength(50)
				.IsRequired();
		}
	}
}
