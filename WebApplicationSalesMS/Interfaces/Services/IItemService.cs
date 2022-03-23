using Ubiety.Dns.Core;
using WebApplicationSalesMS.DTOs.ItemDto;

namespace WebApplicationSalesMS.Interfaces.Services
{
    public interface IItemService
    {
        ItemResponseModel CreateItem(ItemRequestModel model);
        ItemsResponseModel GetAllItems();
        ItemResponseModel GetItem(int id);
        ItemResponseModel DeleteItem(int id);
    }
}