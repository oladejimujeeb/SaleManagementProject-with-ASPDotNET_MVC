using System.Collections.Generic;
using WebApplicationSalesMS.Entities;
namespace WebApplicationSalesMS.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Item CreateItem(Item item);
        bool DeleteItem(int id);
        Item EditItem(Item item);
        IList<Item> GetAllItems();
        Item GetItem(int id);
        IList<Item> GetItemsByItemsIds(IList<int> itemsIDs);
        IList<Item> GetItemByCategory(int categoryId);
        IList<Item> GetItemBySelectedCategory(IList<int>categoryIds);
    }
}