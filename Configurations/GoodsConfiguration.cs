using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class GoodsConfiguration : IEntityTypeConfiguration<Goods>
    {
        public void Configure(EntityTypeBuilder<Goods> builder)
        {
            builder.ToTable("Goods");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.GoodsName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }
}
