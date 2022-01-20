using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public long IdState { get; set; }
        public long? IdCountry { get; set; }
        public string? NameState { get; set; }

        public virtual Country? IdCountryNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
