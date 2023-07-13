using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class WeightConfiguration : IEntityTypeConfiguration<Weight>
    {
        public void Configure(EntityTypeBuilder<Weight> builder)
        {
            builder.ToTable("Weight");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.WeightName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }

}
