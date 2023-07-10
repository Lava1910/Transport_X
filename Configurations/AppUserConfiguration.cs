using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(x => x.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.Dob).IsRequired();
        }
    }
}
