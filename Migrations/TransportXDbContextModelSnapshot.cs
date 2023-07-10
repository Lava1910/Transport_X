﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transport_X.EF;

#nullable disable

namespace Transport_X.Migrations
{
    [DbContext(typeof(TransportXDbContext))]
    partial class TransportXDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Goods", b =>
                {
                    b.Property<string>("GoodsName")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GoodsName");

                    b.ToTable("Goods", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Insurance", b =>
                {
                    b.Property<string>("InsuranceName")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InsuranceName");

                    b.ToTable("Insurance", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoodsName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InsuranceName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Proceeds")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiverAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ReceiverDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ReceiverPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverWard")
                        .HasColumnType("int");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SenderDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SenderPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderWard")
                        .HasColumnType("int");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WeightName")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("OrderId");

                    b.HasIndex("GoodsName");

                    b.HasIndex("InsuranceName");

                    b.HasIndex("ReceiverWard");

                    b.HasIndex("StatusName");

                    b.HasIndex("WeightName");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.PostOffice", b =>
                {
                    b.Property<int>("PostOfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostOfficeId"));

                    b.Property<string>("PostOfficeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WardId")
                        .HasColumnType("int");

                    b.HasKey("PostOfficeId");

                    b.HasIndex("WardId");

                    b.ToTable("PostOffices");
                });

            modelBuilder.Entity("Transport_X.Entities.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinceId"));

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("ProvinceId");

                    b.HasIndex("RegionId");

                    b.ToTable("Provinces", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.ReasonFail", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TypeFail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Code");

                    b.ToTable("Reason_fail", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Transport_X.Entities.Status", b =>
                {
                    b.Property<string>("StatusName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("StatusName");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Ward", b =>
                {
                    b.Property<int>("WardCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WardCode"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("WardName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("WardCode");

                    b.HasIndex("DistrictId");

                    b.ToTable("Wards", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.Weight", b =>
                {
                    b.Property<string>("WeightName")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("WeightName");

                    b.ToTable("Weight", (string)null);
                });

            modelBuilder.Entity("Transport_X.Entities.District", b =>
                {
                    b.HasOne("Transport_X.Entities.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Transport_X.Entities.Order", b =>
                {
                    b.HasOne("Transport_X.Entities.Goods", "Goods")
                        .WithMany("Orders")
                        .HasForeignKey("GoodsName");

                    b.HasOne("Transport_X.Entities.Insurance", "Insurance")
                        .WithMany("Orders")
                        .HasForeignKey("InsuranceName");

                    b.HasOne("Transport_X.Entities.Ward", "Ward")
                        .WithMany("Orders")
                        .HasForeignKey("ReceiverWard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transport_X.Entities.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusName");

                    b.HasOne("Transport_X.Entities.Weight", "Weight")
                        .WithMany("Orders")
                        .HasForeignKey("WeightName");

                    b.Navigation("Goods");

                    b.Navigation("Insurance");

                    b.Navigation("Status");

                    b.Navigation("Ward");

                    b.Navigation("Weight");
                });

            modelBuilder.Entity("Transport_X.Entities.PostOffice", b =>
                {
                    b.HasOne("Transport_X.Entities.Ward", "Ward")
                        .WithMany("PostOffices")
                        .HasForeignKey("WardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("Transport_X.Entities.Province", b =>
                {
                    b.HasOne("Transport_X.Entities.Region", "Region")
                        .WithMany("Provinces")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Transport_X.Entities.Ward", b =>
                {
                    b.HasOne("Transport_X.Entities.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Transport_X.Entities.District", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("Transport_X.Entities.Goods", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Transport_X.Entities.Insurance", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Transport_X.Entities.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Transport_X.Entities.Region", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("Transport_X.Entities.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Transport_X.Entities.Ward", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PostOffices");
                });

            modelBuilder.Entity("Transport_X.Entities.Weight", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
