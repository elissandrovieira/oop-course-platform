﻿using Balta.ContentContext;
using Balta.ContentContext.Enums;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();
      articles.Add(new Article("OOP article", "object-oriented"));
      articles.Add(new Article("C# article", "c-sharp"));
      articles.Add(new Article(".NET article", "dot-net"));

      foreach(var article in articles)
      {
        Console.WriteLine(article.Id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      }

      var courseOop = new Course("OOP fundamentals", "oop-fundamentals");
      var courseCsharp = new Course("C# fundamentals", "csharp-fundamentals");
      var course = new Course("ASP.NET fundamentals", "asp-dotnet-fundamentals");
    }
  }
}