using System.Linq;
using WebApplicationSalesMS.DTOs.CategoryDto;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Interfaces.Repositories;
using WebApplicationSalesMS.Interfaces.Services;

namespace WebApplicationSalesMS.Implementations.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public CategoryResponseModel AddCategory(CreateCategoryRequest  request)
        {
            var categoryExist = _categoryRepository.CategoryExit(request.Name);
            if (categoryExist)
            {
                return new CategoryResponseModel()
                {
                    Message = "Category Name Already Exist",
                    Status = false
                };
            }

            var category = new Category()
            {
                Name = request.Name,
                Description = request.Description
            };
            _categoryRepository.CreateCategory(category);
            return new CategoryResponseModel()
            {
                Status = true,
                Message = "Category Add Successfully",
                Data = new CategoryDto()
                {
                    Name = category.Name,
                    Description = category.Description,
                }
            };
        }

        public CategoriesResponseModel GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories().Select(category=>new CategoryDto()
                {
                    Id = category.Id, 
                    Name = category.Name,
                    Description = category.Description,
                }
            ).ToList();
            return new CategoriesResponseModel()
            {
                Data = categories,
                Status = true
            };
        }

        public CategoryResponseModel GetCategory(int id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null)
            {
                return new CategoryResponseModel()
                {
                    Status = false,
                    Message = "Category not found"
                };
            }

            return new CategoryResponseModel()
            {
                Status = true,
                Data = new CategoryDto()
                {
                    Name = category.Name,
                    Description = category.Description,
                }
            };
        }

        public bool DeleteCategory(int id)
        {
            var cat = _categoryRepository.GetCategory(id);
            var del = _categoryRepository.DeleteCategory(cat);
            return true;
        }

        public CategoryResponseModel UpdateCategory(CategoryDto updateCategoryRequest, int id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null)
            {
                return new CategoryResponseModel() {Status = false, Message = "Failed!!"};
            }

            //category.Id = updateCategoryRequest.Id;
            category.Name = updateCategoryRequest.Name;
            category.Description = updateCategoryRequest.Description;
           var cateUpdate= _categoryRepository.EditCategory(category);
            return new CategoryResponseModel()
                {
                    Status = true,
                    Message = "Updated",
                    Data = new CategoryDto()
                    {
                        //Id = category.Id,
                        Name = category.Name,
                        Description = category.Description
                    }
                };
        }
    }
}