using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Advertising
    {
        public long IdAdvertising { get; set; }
        public long? IdService { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual ServiceCommerce? IdServiceNavigation { get; set; }
    }
}
