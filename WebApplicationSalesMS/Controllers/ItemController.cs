using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationSalesMS.DTOs.ItemDto;
using WebApplicationSalesMS.Interfaces.Services;

namespace WebApplicationSalesMS.Controllers
{
    public class ItemController:Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;

        public ItemController(IItemService itemService, ICategoryService categoryService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
        }

        public IActionResult ItemIndexPage()
        {
            var item = _itemService.GetAllItems();
            ViewBag.Message = item.Message;
            return View(item.Data);
        }

        public IActionResult CreateItem()
        {
            var item = _categoryService.GetAllCategories();
            ViewData["Categories"]= new SelectList(item.Data, "Id","Name");
            return View();
        }

        [HttpPost]
        public IActionResult CreateItem(ItemRequestModel itemRequestModel)
        {
            var item = _itemService.CreateItem(itemRequestModel);
            
            return RedirectToAction("ItemIndexPage");
        }
    }
}