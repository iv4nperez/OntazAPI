using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Subscription
    {
        public Subscription()
        {
            Payments = new HashSet<Payment>();
        }

        public long IdSubscription { get; set; }
        public int? NumberDay { get; set; }
        public string? Description { get; set; }
        public bool? RegDeleted { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
