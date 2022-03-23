using System.Collections.Generic;

namespace WebApplicationSalesMS.DTOs.OrderDto
{
    public class OrdersResponseModel:BaseResposeModel
    {
        public IList<OrderDto>Data { get; set; }
    }
}