using Edura.Repository.Abstract;
using Edura.WebUI.Models.Shopping;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Helpers;

namespace Edura.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository productRepository;

        public CartController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int productId, int quantity = 1)
        {
            var product = productRepository.Get(productId);
            if (product.isNotNull())
            {
                var cart = GetCart();
                cart.AddProduct(product, quantity);

                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var product = productRepository.Get(productId);
            if (product.isNotNull())
            {
                var cart = GetCart();
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("cart", cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
    }
}
