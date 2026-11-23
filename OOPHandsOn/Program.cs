using System;
using System.Collections.Generic;
using System.Text;
using OOPHandsOn.ContentContext;

namespace OOPHandsOn
{
    static class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "c-sharp"));
            articles.Add(new Article("Artigo sobre .NET", "dot-net"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}