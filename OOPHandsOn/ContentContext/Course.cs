using System;
using System.Collections.Generic;
using System.Text;
using OOPHandsOn.ContentContext.Enums;

namespace OOPHandsOn.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url):base(title, url)
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
