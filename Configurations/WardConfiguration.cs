using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("Wards");

            builder.HasKey(x => x.WardCode);

            builder.Property(x => x.WardName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder.HasOne(x => x.District).WithMany(x => x.Wards).HasForeignKey(x => x.DistrictId);
        }
    }
}
