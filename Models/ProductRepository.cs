using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> GetAllProduct 
        {
            get
            {
                return _appDbContext.Products.Include(p=>p.Category);
            }
            /*new Product {ProductId =1, Name="IPad", Price =499.99M, Description="Lorem ipsum dolor sit amet," +
                " consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam,nisi ut aliquid ex ea commodi consequatur.",
            Category =_categoryRepository.GetAllCategories.ToList()[0], ImageUrl="https://en.wikipedia.org/wiki/IPad#/media/File:Steve_Jobs_with_the_Apple_iPad_no_logo_(cropped).jpg",
                IsInStock=true,IsOnSale=false,ImgThumbnailUrl="https://en.wikipedia.org/wiki/IPad#/media/File:Apple_Newton-IMG_0454-cropped.jpg"},


            new Product {ProductId =2, Name="IPhone", Price =499.99M, Description="Lorem ipsum dolor sit amet," +
                " consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam,nisi ut aliquid ex ea commodi consequatur.",
            Category =_categoryRepository.GetAllCategories.ToList()[1], ImageUrl="https://coloradopeakpolitics.com/wp-content/uploads/2013/06/Phone.jpg",
                IsInStock=true,IsOnSale=false,ImgThumbnailUrl="https://coloradopeakpolitics.com/wp-content/uploads/2013/06/Phone.jpg"},

             new Product {ProductId =3, Name="Laptop", Price =499.99M, Description="Lorem ipsum dolor sit amet," +
                " consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam,nisi ut aliquid ex ea commodi consequatur.",
            Category =_categoryRepository.GetAllCategories.ToList()[2], ImageUrl="https://upload.wikimedia.org/wikipedia/commons/6/6c/Acer_Chromebook_11_%2824394834161%29.jpg",
                IsInStock=true,IsOnSale=true,ImgThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/6/6c/Acer_Chromebook_11_%2824394834161%29.jpg"}*/
        }


        public IEnumerable<Product> GetProductOnSale
        {
            get
            {
                return _appDbContext.Products.Include(p => p.Category).Where(p=>p.IsOnSale);
            }

        }
        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(pro => pro.ProductId == productId);
        }
    }
}
