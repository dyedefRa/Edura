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
        private int pageSize = 2;

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

        public IActionResult List(string category,int page=1)
        {
            var products = productRepository.GetAll();
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(x => x.Categories)
                    .Where(x => x.Categories.Any(y => y.Name == category));
            }

            products = products.Skip((page - 1) * pageSize).Take(pageSize);
            return View(products);
        }
    }
}
