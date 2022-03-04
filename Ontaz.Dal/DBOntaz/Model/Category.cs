using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Category
    {
        public Category()
        {
            ServiceCommerces = new HashSet<ServiceCommerce>();
        }

        public long IdCategory { get; set; }
        public string? NameCartegory { get; set; }
        public string? UrlCategory { get; set; }
        public bool? RegDeleted { get; set; }

        public virtual ICollection<ServiceCommerce> ServiceCommerces { get; set; }
    }
}
