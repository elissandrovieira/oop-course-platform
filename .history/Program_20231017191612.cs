using Balta.ContentContext;
using Balta.ContentContext.Enums;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();
      articles.Add(new Article("OOP article", "object-oriented"));
      articles.Add(new Article("C# article", "object-oriented"));
      articles.Add(new Article("Dot article", "object-oriented"));

      foreach(var article in articles)
      {
        Console.WriteLine(article.Id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      }
    }
  }
}