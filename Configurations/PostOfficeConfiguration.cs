using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class PostOfficeConfiguration : IEntityTypeConfiguration<PostOffice>
    {
        public void Configure(EntityTypeBuilder<PostOffice> builder)
        {
            builder.ToTable("PostOffices");
            builder.HasKey(x => x.PostOfficeId);
            builder.Property(x => x.PostOfficeAddress)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.HasOne(x => x.Ward).WithMany(x => x.PostOffices).HasForeignKey(x => x.WardId);
        }
    }
}
