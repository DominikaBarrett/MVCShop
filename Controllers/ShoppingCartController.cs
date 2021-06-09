using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sklep.Models;
using Sklep.ViewModels;

namespace Sklep.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IProductRepository _productRepository;// GET
        private readonly ShoppingCart _shoppingCart;// GET

        public ShoppingCartController(IProductRepository productRepository,ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);



        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.GetAllProduct.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct,1);
            }

            return RedirectToAction("Index");
        }
        
        public RedirectToActionResult RemoveFromShoppingCart(int productId)
                {
                    var selecetedProduct = _productRepository.GetAllProduct.FirstOrDefault(p => p.ProductId == productId);
        
                    if (selecetedProduct != null)
                    {
                        _shoppingCart.RemoveFromCart(selecetedProduct);
                    }
        
                    return RedirectToAction("Index");
                }
    }
}