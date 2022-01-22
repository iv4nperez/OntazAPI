using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.DTOs.Response
{
    public class ServiceListResponse
    {
        public long IdService { get; set; }
        public string NameService { get; set; } = string.Empty;
        public string DescriptionService { get; set; } = string.Empty;
        public string ImageService { get; set; } = string.Empty;
        public int DiscountService { get; set; }
        public int Raiting { get; set; }
    }

    public class ServiceResponse
    {

    }
}
