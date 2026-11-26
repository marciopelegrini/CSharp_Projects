using OOPHandsOn.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHandsOn.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public Boolean IsInactive => EndDate <= DateTime.Now;
    }
}
