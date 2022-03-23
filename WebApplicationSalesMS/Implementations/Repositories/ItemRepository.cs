using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplicationSalesMS.Context;
using WebApplicationSalesMS.Entities;
using WebApplicationSalesMS.Interfaces.Repositories;

namespace WebApplicationSalesMS.Implementations.Repositories
{
    public class ItemRepository:IItemRepository
    {
        private readonly ApplicationContext _context;

        public ItemRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Item CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public bool DeleteItem(int id)
        {
           var item =  _context.Items.Find(id);
           _context.Items.Remove(item);
           _context.SaveChanges();
           return true;
        }

        public Item EditItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
            return item;
        }

        public IList<Item> GetAllItems()
        {
            var item = _context.Items.ToList();
            return item;
        }

        public IList<Item> GetItemsByItemsIds(IList<int> itemsIDs)
        {
            var item = _context.Items.Where(x=> itemsIDs.Contains(x.Id) ).ToList();
            return item;
        }

        public IList<Item> GetItemByCategory(int categoryId)
        {
            var item = _context.Items.Include(x=>x.CategoryItems.Where(x=>x.CategoryId==categoryId)).ToList();
            return item;
        }

        public IList<Item> GetItemBySelectedCategory(IList<int> categoryIds)
        {
            var item = _context.Items.Include(x=>x.CategoryItems.Where(x=> categoryIds.Contains(x.CategoryId) )).ToList();
            return item;
        }

        public Item GetItem(int id)
        {
            var item = _context.Items.Find(id);
            return item;
        }
        
    }
}