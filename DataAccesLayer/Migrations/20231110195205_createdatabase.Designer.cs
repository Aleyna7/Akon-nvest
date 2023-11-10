﻿// <auto-generated />
using System;
using DataAccesLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231110195205_createdatabase")]
    partial class createdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.Property<int>("AdvertID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AdvertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AdvertTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AirCordinator")
                        .HasColumnType("bit");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int>("BathroomNumbers")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<bool>("Credid")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrinctID")
                        .HasColumnType("int");

                    b.Property<bool>("Fireplace")
                        .HasColumnType("bit");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("Furniture")
                        .HasColumnType("bit");

                    b.Property<string>("Garage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Garden")
                        .HasColumnType("bit");

                    b.Property<int>("NeighbourhoodID")
                        .HasColumnType("int");

                    b.Property<bool>("NumberOfRooms")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumbers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pool")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SituationID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Teras")
                        .HasColumnType("bit");

                    b.Property<int>("TypId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserAdminID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserAdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdvertID");

                    b.HasIndex("NeighbourhoodID");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserAdminID");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("EntityLayer.Entities.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("EntityLayer.Entities.GeneralSettings", b =>
                {
                    b.Property<int>("GeneralSettingsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneralSettingsID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneralSettingsID");

                    b.ToTable("GeneralSettings");
                });

            modelBuilder.Entity("EntityLayer.Entities.Images", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int>("AdvertID")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ImageID");

                    b.HasIndex("AdvertID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EntityLayer.Entities.Neighbourhood", b =>
                {
                    b.Property<int>("NeighbourhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NeighbourhoodId"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("NeighbourhoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("NeighbourhoodId");

                    b.HasIndex("DistrictId")
                        .IsUnique();

                    b.ToTable("Neighbourhoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Situation", b =>
                {
                    b.Property<int>("StiuationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StiuationID"));

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StiuationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StiuationID");

                    b.ToTable("Situations");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("SituationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SituationStiuationID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.HasIndex("SituationStiuationID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("EntityLayer.Entities.UserAdmin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("UserAdmins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("IdentityUserLogins");
                });

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.HasOne("EntityLayer.Entities.Neighbourhood", "Neighbourhood")
                        .WithMany()
                        .HasForeignKey("NeighbourhoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.Type", "Type")
                        .WithMany("Advert")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.UserAdmin", "UserAdmin")
                        .WithMany("Adverts")
                        .HasForeignKey("UserAdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighbourhood");

                    b.Navigation("Type");

                    b.Navigation("UserAdmin");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.HasOne("EntityLayer.Entities.City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EntityLayer.Entities.Images", b =>
                {
                    b.HasOne("EntityLayer.Entities.Advert", "Advert")
                        .WithMany("Images")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("EntityLayer.Entities.Neighbourhood", b =>
                {
                    b.HasOne("EntityLayer.Entities.District", "District")
                        .WithOne("Neighbourhood")
                        .HasForeignKey("EntityLayer.Entities.Neighbourhood", "DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.HasOne("EntityLayer.Entities.Situation", "Situation")
                        .WithMany("Types")
                        .HasForeignKey("SituationStiuationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Situation");
                });

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("EntityLayer.Entities.City", b =>
                {
                    b.Navigation("District");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.Navigation("Neighbourhood")
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Entities.Situation", b =>
                {
                    b.Navigation("Types");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.Navigation("Advert");
                });

            modelBuilder.Entity("EntityLayer.Entities.UserAdmin", b =>
                {
                    b.Navigation("Adverts");
                });
#pragma warning restore 612, 618
        }
    }
}
