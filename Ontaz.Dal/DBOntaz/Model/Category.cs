using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }

        public long IdCategory { get; set; }
        public string? NameCartegory { get; set; }
        public string? UrlCategory { get; set; }
        public bool? RegDeleted { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
