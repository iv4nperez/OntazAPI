using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public long IdCountry { get; set; }
        public string? NameCountry { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
