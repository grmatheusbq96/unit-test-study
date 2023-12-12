using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Infra.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);
        }
    }
}
