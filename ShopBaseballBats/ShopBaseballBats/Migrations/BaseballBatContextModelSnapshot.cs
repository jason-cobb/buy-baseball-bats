﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopBaseballBats.Data3;

#nullable disable

namespace ShopBaseballBats.Migrations
{
    [DbContext(typeof(BaseballBatContext))]
    partial class BaseballBatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("ShopBaseballBats.Models.BaseballBats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BaseballBats");
                });

            modelBuilder.Entity("ShopBaseballBats.Models.BatBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BaseballBatsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Cart")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescriptionHtml")
                        .HasColumnType("TEXT");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModelNames")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BaseballBatsId");

                    b.ToTable("BatBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Louisville Slugger",
                            Length = 28,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Louisville Slugger",
                            Length = 29,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 7,
                            BrandName = "Louisville Slugger",
                            Length = 30,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 10,
                            BrandName = "Louisville Slugger",
                            Length = 31,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 13,
                            BrandName = "Louisville Slugger",
                            Length = 32,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 16,
                            BrandName = "Louisville Slugger",
                            Length = 33,
                            ModelNames = "LXT"
                        },
                        new
                        {
                            Id = 19,
                            BrandName = "Louisville Slugger",
                            Length = 28,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 22,
                            BrandName = "Louisville Slugger",
                            Length = 29,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 25,
                            BrandName = "Louisville Slugger",
                            Length = 30,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 28,
                            BrandName = "Louisville Slugger",
                            Length = 31,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 31,
                            BrandName = "Louisville Slugger",
                            Length = 32,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 34,
                            BrandName = "Louisville Slugger",
                            Length = 33,
                            ModelNames = "Meta"
                        },
                        new
                        {
                            Id = 37,
                            BrandName = "Louisville Slugger",
                            Length = 28,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 40,
                            BrandName = "Louisville Slugger",
                            Length = 29,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 43,
                            BrandName = "Louisville Slugger",
                            Length = 30,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 46,
                            BrandName = "Louisville Slugger",
                            Length = 31,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 49,
                            BrandName = "Louisville Slugger",
                            Length = 32,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 52,
                            BrandName = "Louisville Slugger",
                            Length = 33,
                            ModelNames = "Xeno"
                        },
                        new
                        {
                            Id = 56,
                            BrandName = "Easton",
                            Length = 28,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 59,
                            BrandName = "Easton",
                            Length = 29,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 62,
                            BrandName = "Easton",
                            Length = 30,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 65,
                            BrandName = "Easton",
                            Length = 31,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 68,
                            BrandName = "Easton",
                            Length = 32,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 71,
                            BrandName = "Easton",
                            Length = 33,
                            ModelNames = "Ghost"
                        },
                        new
                        {
                            Id = 74,
                            BrandName = "Easton",
                            Length = 28,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 77,
                            BrandName = "Easton",
                            Length = 29,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 80,
                            BrandName = "Easton",
                            Length = 30,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 83,
                            BrandName = "Easton",
                            Length = 31,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 86,
                            BrandName = "Easton",
                            Length = 32,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 89,
                            BrandName = "Easton",
                            Length = 33,
                            ModelNames = "Fire Fly"
                        },
                        new
                        {
                            Id = 93,
                            BrandName = "Rawlings",
                            Length = 28,
                            ModelNames = "Mantra"
                        },
                        new
                        {
                            Id = 96,
                            BrandName = "Rawlings",
                            Length = 29,
                            ModelNames = "Mantra"
                        },
                        new
                        {
                            Id = 99,
                            BrandName = "Rawlings",
                            Length = 30,
                            ModelNames = "Mantra"
                        },
                        new
                        {
                            Id = 102,
                            BrandName = "Rawlings",
                            Length = 31,
                            ModelNames = "Mantra"
                        },
                        new
                        {
                            Id = 105,
                            BrandName = "Rawlings",
                            Length = 32,
                            ModelNames = "Mantra"
                        },
                        new
                        {
                            Id = 108,
                            BrandName = "Rawlings",
                            Length = 33,
                            ModelNames = "Mantra"
                        });
                });

            modelBuilder.Entity("ShopBaseballBats.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ShopBaseballBats.Models.BatBrand", b =>
                {
                    b.HasOne("ShopBaseballBats.Models.BaseballBats", null)
                        .WithMany("BatBrands")
                        .HasForeignKey("BaseballBatsId");
                });

            modelBuilder.Entity("ShopBaseballBats.Models.BaseballBats", b =>
                {
                    b.Navigation("BatBrands");
                });
#pragma warning restore 612, 618
        }
    }
}
