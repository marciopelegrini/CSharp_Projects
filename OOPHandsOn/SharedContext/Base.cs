using OOPHandsOn.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHandsOn.SharedContext
{
    public abstract class Base : Notifiable
    {
        
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
