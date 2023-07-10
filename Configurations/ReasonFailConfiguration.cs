using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class ReasonFailConfiguration : IEntityTypeConfiguration<ReasonFail>
    {
        public void Configure(EntityTypeBuilder<ReasonFail> builder)
        {
            builder.ToTable("Reason_fail");

            builder.HasKey(x => x.Code);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.TypeFail)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder.Property(x => x.Description)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }
}
