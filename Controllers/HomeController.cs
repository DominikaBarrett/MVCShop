using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sklep.Models;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepositoty;

        public HomeController(IProductRepository productRepository)
        {
            _productRepositoty = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _productRepositoty.GetProductOnSale
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
