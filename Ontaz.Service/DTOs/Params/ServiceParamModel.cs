using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontaz.Service.DTOs.Params
{
    public class ServiceParamModel
    {
        public long IdService { get; set; }
        public long IdUser { get; set; }
        public long IdCategory { get; set; }
        public string? NameService { get; set; }
        public bool HomeService { get; set; }
        public string? PhoneService { get; set; }
        public string? InternationalCode { get; set; }
        public string? DescriptionService { get; set; }
        //public string? ImageService { get; set; }
        //public bool? VerifiedService { get; set; }
        public int DiscountService { get; set; }
        public double? Longitud { get; set; }
        public double? Latitud { get; set; }
        //public bool? RegDeleted { get; set; }
        public string? WhatsappService { get; set; }
    }
}
