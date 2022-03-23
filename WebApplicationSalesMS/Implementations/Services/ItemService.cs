using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using WebApplicationSalesMS.DTOs.ItemDto;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Implementations.Repositories;
using WebApplicationSalesMS.Interfaces.Repositories;
using WebApplicationSalesMS.Interfaces.Services;

namespace WebApplicationSalesMS.Implementations.Services
{
    public class ItemService:IItemService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IItemRepository _itemRepository;
        
        public ItemService(IWebHostEnvironment webHostEnvironment, ICategoryRepository categoryRepository, IItemRepository itemRepository)
        {
            _webHostEnvironment = webHostEnvironment;
            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;
        }
        
        public ItemResponseModel CreateItem(ItemRequestModel model)
        {
            string imageName = " ";    
            if (model.FileImage != null)
            {
                var path = _webHostEnvironment.WebRootPath;
                var imagePath = Path.Combine(path, "myImages");
                Directory.CreateDirectory(imagePath);
                var imageType = model.FileImage.ContentType.Split('/')[1];
                imageName = $"{Guid.NewGuid()}.{imageType}";
                var fullpath = Path.Combine(imagePath, imageName);
                using (var fileStream = new FileStream(fullpath, FileMode.Create))
                {
                    model.FileImage.CopyTo(fileStream);
                }
            }
            var item = new Item()
            {
                Name = model.Name,
                Description = model.Description,
                Image = imageName,
                Price = model.Price,
            };
            var categories = _categoryRepository.GetCategoriesByIds(model.CategoryIds);
            foreach (var cat in categories)
            {
                var cateGoryItem = new CategoryItem()
                {
                    ItemId = item.Id,
                    Item = item,
                    Category = cat,
                    CategoryId = cat.Id,
                    
                };
                item.CategoryItems.Add(cateGoryItem );
            }
            
            var myItem = _itemRepository.CreateItem(item);
            if (myItem == null)
            {
                return new ItemResponseModel(){Message = "failed to Add", Status = false};
            }

            return new ItemResponseModel()
            {
                Data = new ItemDto
                {
                    Name = item.Name,
                    Description = item.Description,
                    Image = item.Image,
                    Price = item.Price,
                    //CategoryItems = myItem.CategoryItems,
                    //OrderItems = myItem.OrderItems
                },
                Message = "Item Successfully Added", Status = true
            };

        }

        public ItemsResponseModel GetAllItems()
        {
            var items = _itemRepository.GetAllItems().Select(item=>new ItemDto()
            {
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Image = item.Image,
            }).ToList();
            return new ItemsResponseModel()
            {
                Status = true,
                Data = items
            };
        }

        public ItemResponseModel GetItem(int id)
        {
            var item = _itemRepository.GetItem(id);
            if (item == null)
            {
                return new ItemResponseModel {Status = false, Message = "Item Not found"};
            }

            return new ItemResponseModel()
            {
                Status = true, Data = new ItemDto
                {
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Image = item.Image
                }
            };
        }

        public ItemResponseModel DeleteItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}