using System;
using System.Collections.Generic;

namespace Ontaz.Dal.DBOntaz.Model
{
    public partial class Payment
    {
        public long IdPayment { get; set; }
        public long? IdSubscription { get; set; }
        public long? IdService { get; set; }

        public virtual Service? IdServiceNavigation { get; set; }
        public virtual Subscription? IdSubscriptionNavigation { get; set; }
    }
}
