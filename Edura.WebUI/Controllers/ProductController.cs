using Edura.Repository.Abstract;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;

        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = productRepository
                .GetAll()
                .Where(x => x.Id == id)
                .Include(x => x.Categories)
                //.ThenInclude(x=>x.)
                .Include(x => x.Images)
                .Include(x => x.ProductDetails)
                .Select(x =>
                new ProductDetailsModel()
                {
                    Product = x,
                    Images = x.Images,
                    ProductDetails = x.ProductDetails,
                    Categories = x.Categories
                }).FirstOrDefault();
            return View(model);
        }
    }
}
