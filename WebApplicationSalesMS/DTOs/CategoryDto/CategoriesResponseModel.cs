using System.Collections.Generic;

namespace WebApplicationSalesMS.DTOs.CategoryDto
{
    public class CategoriesResponseModel:BaseResposeModel
    {
        public IList<CategoryDto>Data { get; set; }
    }
}