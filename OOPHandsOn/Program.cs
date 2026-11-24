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

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine();
            Console.WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");
            Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);
            Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

            Console.WriteLine();
            decimal value = 0.34M;
            Console.WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);
        }
    }
}