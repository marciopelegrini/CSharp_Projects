using OOPHandsOn.NotificationContext;
using OOPHandsOn.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHandsOn.SubscriptionContext
{
    public class Student : Base
    {
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremiun => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremiun)
            {
                AddNotification(new Notification("Premium", "O aluno ja tem uma assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}