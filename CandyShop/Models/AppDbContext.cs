using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candy>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Kẹo cứng" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Kẹo chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Kẹo trái cây" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Kẹo dẻo" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Kẹo Halloween" });


            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 1,
                Name = "Kẹo Chocolate thập cẩm",
                Price = 4.95M,
                Description = "Kẹo chocolate với nhiều hương khác nhau.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 2,
                Name = "Kẹo Chocolate thập cẩm 2",
                Price = 3.95M,
                Description = "Kẹo chocolate với nhiều hương khác nhau.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy2.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 3,
                Name = "Kẹo Chocolate",
                Price = 5.75M,
                Description = "Kẹo chocolate đắng.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy3.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 4,
                Name = "Kẹo trái cây thập cẩm",
                Price = 3.95M,
                Description = "Kẹo trái cây nhiều hương.",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 5,
                Name = "Kẹo trái cây",
                Price = 7.00M,
                Description = "Kẹo hương trái cây.",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy2.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 6,
                Name = "Kẹo trái cây thập cẩm 2",
                Price = 11.25M,
                Description = "Kẹo nhiều hương vị.",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy3.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 7,
                Name = "Kẹo dẻo thập cẩm",
                Price = 3.95M,
                Description = "Kẹo dẻo nhiều hương vị.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 8,
                Name = "Kẹo dẻo thập cẩm 2",
                Price = 1.95M,
                Description = "Kẹo dẻo nhiều hương vị.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy2.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 9,
                Name = "Kẹo dẻo",
                Price = 13.95M,
                Description = "Kẹo siêu dẻo.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy3.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 10,
                Name = "Kẹo Halloween",
                Price = 1.95M,
                Description = "Kẹo dịp lễ Halloween.",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 11,
                Name = "Kẹo Halloween thập cẩm",
                Price = 12.95M,
                Description = "Kẹo Halloween nhiều hương.",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy2.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 12,
                Name = "Kẹo Halloween 2",
                Price = 21.95M,
                Description = "Kẹo dịp Halloween.",
                CategoryId = 4,
                ImageUrl = "\\Images\\halloweenCandy3.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 13,
                Name = "Kẹo cứng",
                Price = 6.95M,
                Description = "Kẹo cứng hương theo màu.",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\hardCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 14,
                Name = "Kẹo cứng 2",
                Price = 2.95M,
                Description = "Kẹo cứng hương theo màu.",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy2.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 15,
                Name = "Kẹo cứng ngon",
                Price = 16.95M,
                Description = "Kẹo cứng hương theo màu.",
                CategoryId = 5,
                ImageUrl = "\\Images\\hardCandy3.jpg",
                ImageThumbnail = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
