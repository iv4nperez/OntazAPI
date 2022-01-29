using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Service
    {
        public Service()
        {
            Advertisings = new HashSet<Advertising>();
            Payments = new HashSet<Payment>();
            Products = new HashSet<Product>();
        }

        public long IdService { get; set; }
        public long? IdUser { get; set; }
        public long? IdCategory { get; set; }
        public string? NameService { get; set; }
        public bool? HomeService { get; set; }
        public string? PhoneService { get; set; }
        public string? InternationalCode { get; set; }
        public string? DescriptionService { get; set; }
        public string? ImageService { get; set; }
        public bool? VerifiedService { get; set; }
        public int? DiscountService { get; set; }
        public double? Longitud { get; set; }
        public double? Latitud { get; set; }
        public bool? RegDeleted { get; set; }
        public string? WhatsappService { get; set; }

        public virtual Category? IdCategoryNavigation { get; set; }
        public virtual User? IdUserNavigation { get; set; }
        public virtual ICollection<Advertising> Advertisings { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
