using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("Insurance");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.InsuranceName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }
}
