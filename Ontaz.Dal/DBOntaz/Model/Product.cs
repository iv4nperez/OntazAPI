using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Product
    {
        public long IdProduct { get; set; }
        public long? IdService { get; set; }
        public string? NameProduct { get; set; }
        public string? UrlProduct { get; set; }
        public decimal? PriceProduct { get; set; }
        public int? DiscountProduct { get; set; }
        public bool? RegDeleted { get; set; }

        public virtual Service? IdServiceNavigation { get; set; }
    }
}
