using System.Collections.Generic;

namespace WebApplicationSalesMS.DTOs.CustomerDto
{
    public class CustomersResponseModel:BaseResposeModel
    {
        public IList<CustomerDto>Data { get; set; }
    }
}