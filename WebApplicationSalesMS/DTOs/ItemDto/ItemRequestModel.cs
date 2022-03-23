using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace WebApplicationSalesMS.DTOs.ItemDto
{
    public class ItemRequestModel//:BaseResposeModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public IFormFile FileImage{ get; set; }
        public IList<int> CategoryIds { get; set; } = new List<int>();
    }
}