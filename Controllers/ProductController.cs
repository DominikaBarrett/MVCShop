using Microsoft.AspNetCore.Mvc;
using Sklep.Models;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //   ViewBag.CurrentCategory = "Best Sellers";
            //  return View(_productRepository.GetAllProduct);
            var productListViewModel = new ProductListModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            productListViewModel.CurrentCategory = "BestSellers";
            return View(productListViewModel);
        }
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
