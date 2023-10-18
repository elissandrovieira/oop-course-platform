using Platform.ContentContext;
using Platform.ContentContext.Enums;

namespace Platform
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

      var courses = new List<Course>();

      var courseOop = new Course("OOP fundamentals", "oop-fundamentals");
      var courseCsharp = new Course("C# fundamentals", "csharp-fundamentals");
      var courseAspnet = new Course("ASP.NET fundamentals", "aspnet-fundamentals");r

      courses.Add(courseOop);
      courses.Add(courseCsharp);
      courses.Add(courseAspnet);

      var career = new Career()
    }
  }
}