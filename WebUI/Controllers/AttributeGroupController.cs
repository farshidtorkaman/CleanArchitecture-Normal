using Application.Services.AttributeGroups;
using Application.Services.AttributeGroups.ViewModels;
using Application.Services.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AttributeGroupController : Controller
    {
        private readonly IAttributeGroupService _attributeGroupService;
        private readonly ICategoryService _categoryService;

        public AttributeGroupController(IAttributeGroupService attributeGroupService,
                                        ICategoryService categoryService)
        {
            _attributeGroupService = attributeGroupService;

            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _attributeGroupService.ListAsync());
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.CategoryId = new SelectList(await _categoryService.GetAsQueryable(), "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AttributeGroupViewModel model)
        {
            await _attributeGroupService.Add(model);

            return RedirectToAction("Index");
        }
    }
}