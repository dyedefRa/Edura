using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }


        public IActionResult Index()
        {
            return View(productRepository.Products);
        }
    }
}
