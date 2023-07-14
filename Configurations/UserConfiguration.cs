using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class UserConfiguration
    {
        public class AppUserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("Users");

                builder.HasKey(x => x.UserId);

                builder.Property(x => x.UserName)
                    .IsRequired()
                    .HasMaxLength(255);
                builder.Property(x => x.Password)
                    .IsRequired()
                    .HasMaxLength(255);
                builder.Property(x => x.Email)
                    .IsRequired();
                builder.Property(x => x.Phone)
                    .IsRequired();
                builder.Property(x => x.Role)
                    .IsRequired()
                    .HasMaxLength(255);

            }
        }
    }
}
