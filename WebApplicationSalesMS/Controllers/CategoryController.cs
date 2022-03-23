using Microsoft.AspNetCore.Mvc;
using WebApplicationSalesMS.DTOs.CategoryDto;
using WebApplicationSalesMS.Interfaces.Services;

namespace WebApplicationSalesMS.Controllers
{
    public class CategoryController:Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            ViewBag.Message = categories.Message;
            return View((categories.Data));
        }

        public IActionResult Get(int id)
        {
            var category = _categoryService.GetCategory(id);
            return View(category);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequest createCategoryRequest)
        {
            var createCatgory = _categoryService.AddCategory(createCategoryRequest);
            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var cat = _categoryService.GetCategory(id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }
        [HttpPost]
        public IActionResult Update(CategoryDto updateCategoryRequest, int id)
        {
            var updatecat = _categoryService.UpdateCategory(updateCategoryRequest, id);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id, CategoryDto categoryDto)
        {
            var del = _categoryService.GetCategory(id);
            if (del == null) return NotFound();
            return View(del);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var del = _categoryService.DeleteCategory(id);
            return RedirectToAction("index");
        }
    }
}