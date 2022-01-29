using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class VwServicesDetail
    {
        public long IdService { get; set; }
        public long? IdCategory { get; set; }
        public string? NameService { get; set; }
        public string? DescriptionService { get; set; }
        public string? ImageService { get; set; }
        public bool? HomeService { get; set; }
        public int? DiscountService { get; set; }
        public string? InternationalCode { get; set; }
        public string? PhoneService { get; set; }
        public string? WhatsappService { get; set; }
        public long? IdUser { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public bool? RegDeleted { get; set; }
        public bool? VerifiedService { get; set; }
        public decimal? Raiting { get; set; }
    }
}
