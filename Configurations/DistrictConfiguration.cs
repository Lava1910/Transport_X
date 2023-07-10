using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts");

            builder.HasKey(x => x.DistrictId);

            builder.Property(x => x.DistrictName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder.HasOne(x => x.Province).WithMany(x => x.Districts).HasForeignKey(x => x.ProvinceId);
        }
    }
}
