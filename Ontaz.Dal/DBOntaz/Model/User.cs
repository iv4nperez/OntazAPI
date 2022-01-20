using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class User
    {
        public User()
        {
            Services = new HashSet<Service>();
        }

        public long IdUser { get; set; }
        public long? IdCity { get; set; }
        public string? NameUser { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Picture { get; set; }
        public bool? CreateService { get; set; }
        public bool? RegDeleted { get; set; }

        public virtual City? IdCityNavigation { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
