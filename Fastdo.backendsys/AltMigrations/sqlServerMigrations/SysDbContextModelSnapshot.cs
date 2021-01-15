﻿// <auto-generated />
using System;
using Fastdo.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fastdo.backendsys.Migrations
{
    [DbContext(typeof(SysDbContext))]
    partial class SysDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fastdo.Core.Models.Admin", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SuperAdminId");

                    b.HasKey("Id");

                    b.HasIndex("SuperAdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Fastdo.Core.Models.AdminHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Desc");

                    b.Property<string>("IssuerId");

                    b.Property<DateTime>("OccuredAt");

                    b.Property<string>("OperationType");

                    b.Property<string>("ToId");

                    b.HasKey("Id");

                    b.ToTable("AdminHistoryEntries");
                });

            modelBuilder.Entity("Fastdo.Core.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("confirmCode")
                        .HasMaxLength(15);

                    b.Property<string>("willBeNewEmail");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Fastdo.Core.Models.Area", b =>
                {
                    b.Property<byte>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte?>("SuperAreaId");

                    b.HasKey("Id");

                    b.HasIndex("SuperAreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Fastdo.Core.Models.Complain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.ToTable("Complains");
                });

            modelBuilder.Entity("Fastdo.Core.Models.LzDrug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConsumeType");

                    b.Property<string>("Desc");

                    b.Property<double>("Discount");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PharmacyId")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<int>("PriceType");

                    b.Property<int>("Quantity");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("UnitType");

                    b.Property<DateTime>("ValideDate");

                    b.HasKey("Id");

                    b.HasIndex("PharmacyId");

                    b.ToTable("LzDrugs");
                });

            modelBuilder.Entity("Fastdo.Core.Models.LzDrugRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("LzDrugId");

                    b.Property<string>("PharmacyId")
                        .IsRequired();

                    b.Property<bool>("Seen");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("PharmacyId");

                    b.HasIndex("LzDrugId", "PharmacyId")
                        .IsUnique();

                    b.ToTable("LzDrugRequests");
                });

            modelBuilder.Entity("Fastdo.Core.Models.Pharmacy", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Address");

                    b.Property<byte>("AreaId");

                    b.Property<string>("CommercialRegImgSrc")
                        .IsRequired();

                    b.Property<string>("LandlinePhone")
                        .IsRequired();

                    b.Property<string>("LicenseImgSrc")
                        .IsRequired();

                    b.Property<string>("MgrName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("OwnerName")
                        .IsRequired();

                    b.Property<string>("PersPhone")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("Fastdo.Core.Models.PharmacyInStock", b =>
                {
                    b.Property<string>("PharmacyId");

                    b.Property<string>("StockId");

                    b.Property<int>("PharmacyReqStatus");

                    b.Property<bool>("Seen");

                    b.HasKey("PharmacyId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("PharmaciesInStocks");
                });

            modelBuilder.Entity("Fastdo.Core.Models.PharmacyInStockClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PharmacyId");

                    b.Property<Guid>("StockClassId");

                    b.HasKey("Id");

                    b.HasIndex("StockClassId");

                    b.HasIndex("PharmacyId", "StockClassId")
                        .IsUnique()
                        .HasFilter("[PharmacyId] IS NOT NULL");

                    b.ToTable("PharmaciesInStockClasses");
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discount")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("Price");

                    b.Property<string>("StockId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("StkDrugs");
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrugInStkDrgPackageReq", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Quantity");

                    b.Property<Guid>("StkDrugId");

                    b.Property<Guid>("StkPackageId");

                    b.Property<string>("StockId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StkPackageId");

                    b.HasIndex("StkDrugId", "StkPackageId")
                        .IsUnique();

                    b.ToTable("StkDrugInStkDrgPackagesRequests");
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrugPackageRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PackageDetails")
                        .IsRequired();

                    b.Property<string>("PharmacyId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PharmacyId");

                    b.ToTable("StkDrugPackagesRequests");
                });

            modelBuilder.Entity("Fastdo.Core.Models.Stock", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Address");

                    b.Property<byte>("AreaId");

                    b.Property<string>("CommercialRegImgSrc")
                        .IsRequired();

                    b.Property<string>("LandlinePhone")
                        .IsRequired();

                    b.Property<string>("LicenseImgSrc")
                        .IsRequired();

                    b.Property<string>("MgrName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("OwnerName")
                        .IsRequired();

                    b.Property<string>("PersPhone")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Fastdo.Core.Models.StockInStkDrgPackageReq", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("PackageId");

                    b.Property<bool>("Seen");

                    b.Property<int>("Status");

                    b.Property<string>("StockId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("StockId", "PackageId")
                        .IsUnique();

                    b.ToTable("StockInStkDrgPackageReqs");
                });

            modelBuilder.Entity("Fastdo.Core.Models.StockWithPharmaClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<string>("StockId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StockId", "ClassName")
                        .IsUnique()
                        .HasFilter("[ClassName] IS NOT NULL");

                    b.ToTable("StocksWithPharmaClasses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Fastdo.Core.Models.Admin", b =>
                {
                    b.HasOne("Fastdo.Core.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.Admin", "SuperAdmin")
                        .WithMany("SubAdmins")
                        .HasForeignKey("SuperAdminId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Fastdo.Core.Models.Area", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Area", "SuperArea")
                        .WithMany("SubAreas")
                        .HasForeignKey("SuperAreaId");
                });

            modelBuilder.Entity("Fastdo.Core.Models.LzDrug", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Pharmacy", "Pharmacy")
                        .WithMany("LzDrugs")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.LzDrugRequest", b =>
                {
                    b.HasOne("Fastdo.Core.Models.LzDrug", "LzDrug")
                        .WithMany("RequestingPharms")
                        .HasForeignKey("LzDrugId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.Pharmacy", "Pharmacy")
                        .WithMany("RequestedLzDrugs")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.Pharmacy", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.PharmacyInStock", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Pharmacy", "Pharmacy")
                        .WithMany("GoinedStocks")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Fastdo.Core.Models.Stock", "Stock")
                        .WithMany("GoinedPharmacies")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Fastdo.Core.Models.PharmacyInStockClass", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Pharmacy", "Pharmacy")
                        .WithMany("StocksClasses")
                        .HasForeignKey("PharmacyId");

                    b.HasOne("Fastdo.Core.Models.StockWithPharmaClass", "StockClass")
                        .WithMany("PharmaciesOfThatClass")
                        .HasForeignKey("StockClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrug", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Stock", "Stock")
                        .WithMany("SDrugs")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrugInStkDrgPackageReq", b =>
                {
                    b.HasOne("Fastdo.Core.Models.StkDrug", "StkDrug")
                        .WithMany("RequestedPackages")
                        .HasForeignKey("StkDrugId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.StockInStkDrgPackageReq", "StockPackage")
                        .WithMany("AssignedStkDrugs")
                        .HasForeignKey("StkPackageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.StkDrugPackageRequest", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Pharmacy", "Pharmacy")
                        .WithMany("RequestedStkDrugsPackages")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.Stock", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.StockInStkDrgPackageReq", b =>
                {
                    b.HasOne("Fastdo.Core.Models.StkDrugPackageRequest", "Package")
                        .WithMany("AssignedStocks")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.Stock", "Stock")
                        .WithMany("RequestedPackages")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fastdo.Core.Models.StockWithPharmaClass", b =>
                {
                    b.HasOne("Fastdo.Core.Models.Stock", "Stock")
                        .WithMany("PharmasClasses")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Fastdo.Core.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Fastdo.Core.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fastdo.Core.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Fastdo.Core.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
