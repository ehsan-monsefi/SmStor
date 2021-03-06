// <auto-generated />
using System;
using Infrastructure.Sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Sql.Migrations
{
    [DbContext(typeof(SmContext))]
    [Migration("20211209120354_A4")]
    partial class A4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entittes.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CameraCategoryId");

                    b.Property<string>("CameraDescription")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CameraInsertTime");

                    b.Property<string>("CameraName")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CameraPrice");

                    b.HasKey("CameraID");

                    b.HasIndex("CameraCategoryId");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("Domain.Entittes.CameraCategory", b =>
                {
                    b.Property<int>("CameraCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CameraCategoryName");

                    b.HasKey("CameraCategoryId");

                    b.ToTable("CameraCategory");
                });

            modelBuilder.Entity("Domain.Entittes.CameraMedia", b =>
                {
                    b.Property<int>("CameraMediaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CameraID");

                    b.Property<string>("CameraPicPath");

                    b.HasKey("CameraMediaId");

                    b.HasIndex("CameraID");

                    b.ToTable("CameraMedia");
                });

            modelBuilder.Entity("Domain.Entittes.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.Entittes.Laptop", b =>
                {
                    b.Property<int>("LaptopID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LaptopCategoryId");

                    b.Property<string>("LaptopDescription")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("LaptopInsertTime");

                    b.Property<string>("LaptopName")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("LaptopPrice");

                    b.HasKey("LaptopID");

                    b.HasIndex("LaptopCategoryId");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("Domain.Entittes.LaptopCategory", b =>
                {
                    b.Property<int>("LaptopCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LaptopCategoryName");

                    b.HasKey("LaptopCategoryId");

                    b.ToTable("LaptopCategory");
                });

            modelBuilder.Entity("Domain.Entittes.LaptopMedia", b =>
                {
                    b.Property<int>("LaptopMediaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LaptopID");

                    b.Property<string>("LaptopPicPath");

                    b.HasKey("LaptopMediaId");

                    b.HasIndex("LaptopID");

                    b.ToTable("LaptopMedia");
                });

            modelBuilder.Entity("Domain.Entittes.Media", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PicPath");

                    b.Property<int?>("ProductID");

                    b.HasKey("MediaId");

                    b.HasIndex("ProductID");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("Domain.Entittes.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("InsertTime");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Price");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entittes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("City");

                    b.Property<DateTime>("Datebourn");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password");

                    b.Property<string>("Repassword");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entittes.Camera", b =>
                {
                    b.HasOne("Domain.Entittes.CameraCategory", "CameraCategory")
                        .WithMany("Cameras")
                        .HasForeignKey("CameraCategoryId");
                });

            modelBuilder.Entity("Domain.Entittes.CameraMedia", b =>
                {
                    b.HasOne("Domain.Entittes.Camera")
                        .WithMany("CamerapMedia")
                        .HasForeignKey("CameraID");
                });

            modelBuilder.Entity("Domain.Entittes.Laptop", b =>
                {
                    b.HasOne("Domain.Entittes.LaptopCategory", "LaptopCategory")
                        .WithMany("Laptop")
                        .HasForeignKey("LaptopCategoryId");
                });

            modelBuilder.Entity("Domain.Entittes.LaptopMedia", b =>
                {
                    b.HasOne("Domain.Entittes.Laptop")
                        .WithMany("LaptopMedia")
                        .HasForeignKey("LaptopID");
                });

            modelBuilder.Entity("Domain.Entittes.Media", b =>
                {
                    b.HasOne("Domain.Entittes.Product")
                        .WithMany("Media")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("Domain.Entittes.Product", b =>
                {
                    b.HasOne("Domain.Entittes.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
