using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class FeaturedMenu:ViewComponent
    {
        private IProductRepository productRepository;
        public FeaturedMenu(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(productRepository.Find(x => x.IsFeatured == true));
        }
    }
}
