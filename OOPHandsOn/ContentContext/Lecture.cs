using OOPHandsOn.ContentContext.Enums;
using OOPHandsOn.SharedContext;

namespace OOPHandsOn.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public double DurationInMinutes { get; set; }
    }
}