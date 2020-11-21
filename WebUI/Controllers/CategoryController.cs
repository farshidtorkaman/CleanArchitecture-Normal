using Application.Services.Categories;
using Application.Services.Categories.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.ListAsync());
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.ParentId = new SelectList(await _categoryService.GetAsQueryable(), "Id", "Name");

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            await _categoryService.Add(model);

            return RedirectToAction("Index");
        }
    }
}