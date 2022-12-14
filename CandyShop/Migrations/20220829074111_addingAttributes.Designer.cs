// <auto-generated />
using System;
using CandyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220829074111_addingAttributes")]
    partial class addingAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "Kẹo chocolate với nhiều hương khác nhau.",
                            ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo Chocolate thập cẩm",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 1,
                            Description = "Kẹo chocolate với nhiều hương khác nhau.",
                            ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo Chocolate thập cẩm 2",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 1,
                            Description = "Kẹo chocolate đắng.",
                            ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                            ImageUrl = "\\Images\\chocolateCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo Chocolate",
                            Price = 5.75m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = "Kẹo trái cây nhiều hương.",
                            ImageThumbnail = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo trái cây thập cẩm",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = "Kẹo hương trái cây.",
                            ImageThumbnail = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo trái cây",
                            Price = 7.00m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = "Kẹo nhiều hương vị.",
                            ImageThumbnail = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageUrl = "\\Images\\fruitCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo trái cây thập cẩm 2",
                            Price = 11.25m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Kẹo dẻo nhiều hương vị.",
                            ImageThumbnail = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo dẻo thập cẩm",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 3,
                            Description = "Kẹo dẻo nhiều hương vị.",
                            ImageThumbnail = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo dẻo thập cẩm 2",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 3,
                            Description = "Kẹo siêu dẻo.",
                            ImageThumbnail = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                            ImageUrl = "\\Images\\gummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo dẻo",
                            Price = 13.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 4,
                            Description = "Kẹo dịp lễ Halloween.",
                            ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo Halloween",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 4,
                            Description = "Kẹo Halloween nhiều hương.",
                            ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo Halloween thập cẩm",
                            Price = 12.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = "Kẹo dịp Halloween.",
                            ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                            ImageUrl = "\\Images\\halloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo Halloween 2",
                            Price = 21.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 5,
                            Description = "Kẹo cứng hương theo màu.",
                            ImageThumbnail = "\\Images\\thumbnails\\hardCandy-small.jpg",
                            ImageUrl = "\\Images\\hardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo cứng",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 5,
                            Description = "Kẹo cứng hương theo màu.",
                            ImageThumbnail = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                            ImageUrl = "\\Images\\hardCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Kẹo cứng 2",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 5,
                            Description = "Kẹo cứng hương theo màu.",
                            ImageThumbnail = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                            ImageUrl = "\\Images\\hardCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Kẹo cứng ngon",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Kẹo cứng"
                        },
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kẹo chocolate"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Kẹo trái cây"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kẹo dẻo"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Kẹo Halloween"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CandyId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });
#pragma warning restore 612, 618
        }
    }
}
