using Application.Services.AttributeGroups;
using Application.Services.Attributes;
using Application.Services.Attributes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AttributeController : Controller
    {
        private readonly IAttributeService _attributeService;
        private readonly IAttributeGroupService _attributeGroupService;

        public AttributeController(IAttributeService attributeService,
                                   IAttributeGroupService attributeGroupService)
        {
            _attributeService = attributeService;

            _attributeGroupService = attributeGroupService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _attributeService.ListAsync());
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.AttributeGroupId = new SelectList(await _attributeGroupService.GetAsQueryable(), "Id", "Title");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AttributeViewModel model)
        {
            await _attributeService.AddAsync(model);

            return RedirectToAction("Index");
        }
    }
}