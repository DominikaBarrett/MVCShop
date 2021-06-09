using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tablet" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Telefon" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Watch" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Vehicle" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Surprise" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "IPad",
                Price = 499.99M,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +
                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                CategoryId = 1,
                ImageUrl = "\\img\\ipad.jpg",
                ImgThumbnailUrl = "\\img\\ipad.jpg",
                IsInStock = true,
                IsOnSale =true,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "IPhone",
                Price = 499.99M,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +
                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                CategoryId = 2,
                ImageUrl = "\\img\\iphone.jpg",
                ImgThumbnailUrl = "\\img\\iphone.jpg",
                IsInStock = true,
                IsOnSale = true,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Smart watch",
                Price = 499.99M,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +
                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                CategoryId = 3,
                ImageUrl = "\\img\\watch.jpg",
                ImgThumbnailUrl = "\\img\\watch.jpg",
                IsInStock = true,
                IsOnSale = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Vehicle",
                Price = 499.99M,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +
                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                CategoryId = 4,
                ImageUrl = "\\img\\Quad.jpg",
                ImgThumbnailUrl = "\\img\\watch.jpg",
                IsInStock = true,
                IsOnSale = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Surprise",
                Price = 499.99M,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +
                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                CategoryId = 5,
                ImageUrl = "\\img\\apple.jpg",
                ImgThumbnailUrl = "\\img\\watch.jpg",
                IsInStock = true,
                IsOnSale = true,
            });
        }
    }

}
