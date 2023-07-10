using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Provinces");

            builder.HasKey(x => x.ProvinceId);

            builder.Property(x => x.ProvinceName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.HasOne(x => x.Region).WithMany(x => x.Provinces).HasForeignKey(x => x.RegionId);
        }
    }
}
