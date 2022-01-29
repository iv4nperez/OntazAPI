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
        public long IdService { get; set; }
        public long IdCategory { get; set; }
        public string NameService { get; set; } = "";
        public bool HomeService { get; set; }
        public string PhoneService { get; set; } = "";
        public string InternationalCode { get; set; } = "";
        public string DescriptionService { get; set; } = "";
        public string ImageService { get; set; } = "";
        public bool VerifiedService { get; set; }
        public int DiscountService { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public decimal Raiting { get; set; }
        public string WhatsappService { get; set; } = "";
    }
}
