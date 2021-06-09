using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public class CategoryRepositorycs : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepositorycs(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
        
           /* new Category{CategoryId =1,CategoryName="Tablet",Description="Fantastic Present"},
            new Category{CategoryId =2,CategoryName="Telefon",Description="Awsome"},
            new Category{CategoryId =3,CategoryName="Laptop",Description="Handy"}*/

        

        
    }
}
