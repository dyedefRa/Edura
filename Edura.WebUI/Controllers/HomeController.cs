using Edura.Entity.Models;
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

        private IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork _unitOfWork,IProductRepository _productRepository)
        {
            productRepository = _productRepository;
            unitOfWork = _unitOfWork;
        }


        public IActionResult Index()
        {
            var model = unitOfWork.Products.GetAll().Where(x => x.IsApproved && x.isHome).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            //var product = new Product()
            //{
            //    Name = "test yeni",
            //    Price = 1001
            //};
            //unitOfWork.Products.Add(product);
            //unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
