using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class City
    {
        public City()
        {
            Users = new HashSet<User>();
        }

        public long IdCity { get; set; }
        public long? IdState { get; set; }
        public string? NameCity { get; set; }

        public virtual State? IdStateNavigation { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
