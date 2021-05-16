using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository categoryRepository;
        public CategoryMenu(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(categoryRepository.GetAllWithProductCount());
        }
    }
}
