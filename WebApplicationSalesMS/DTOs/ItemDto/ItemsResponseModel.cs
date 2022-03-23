using System.Collections.Generic;

namespace WebApplicationSalesMS.DTOs.ItemDto
{
    public class ItemsResponseModel:BaseResposeModel
    {
        public IList<ItemDto>Data { get; set; }
    }
}