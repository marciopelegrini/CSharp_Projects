using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHandsOn.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {
        }
    }
}