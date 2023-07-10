using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Transport_X.Entities;

namespace Transport_X.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.OrderId);
            builder.Property(x => x.SenderName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.ReceiverName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.SenderPhone)
                .IsRequired();
            builder.Property(x => x.ReceiverPhone)
                .IsRequired();
            builder.Property(x => x.SenderAddress)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.ReceiverAddress)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.Property(x => x.Note)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
            builder.HasOne(x => x.Ward).WithMany(x => x.Orders).HasForeignKey(x => x.SenderWard);
            builder.HasOne(x => x.Ward).WithMany(x => x.Orders).HasForeignKey(x => x.ReceiverWard);
            builder.HasOne(x => x.Goods).WithMany(x => x.Orders).HasForeignKey(x => x.GoodsName);
            builder.HasOne(x => x.Weight).WithMany(x => x.Orders).HasForeignKey(x => x.WeightName);
            builder.HasOne(x => x.Insurance).WithMany(x => x.Orders).HasForeignKey(x => x.InsuranceName);
            builder.HasOne(x => x.Status).WithMany(x => x.Orders).HasForeignKey(x => x.StatusName);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
        }
    }
}