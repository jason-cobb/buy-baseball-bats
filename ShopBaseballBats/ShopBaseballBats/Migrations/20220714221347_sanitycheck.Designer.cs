// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopBaseballBats.Data2;

#nullable disable

namespace ShopBaseballBats.Migrations
{
    [DbContext(typeof(BaseballBatContext))]
    [Migration("20220714221347_sanitycheck")]
    partial class sanitycheck
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopBaseballBats.Models.BaseballBats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BaseballBats");
                });

            modelBuilder.Entity("ShopBaseballBats.Models.BatBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BaseballBatsId")
                        .HasColumnType("int");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cart")
                        .HasColumnType("bit");

                    b.Property<string>("DescriptionHtml")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("ModelNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseballBatsId");

                    b.ToTable("BatBrands");
                });

            modelBuilder.Entity("ShopBaseballBats.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

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
