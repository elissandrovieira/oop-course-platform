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
      var courseAspnet = new Course("ASP.NET fundamentals", "aspnet-fundamentals");

      courses.Add(courseOop);
      courses.Add(courseCsharp);
      courses.Add(courseAspnet);

      var careerDotnet = new Career(".Net specialist", "dotnet-specialist");
      var careerItem = new CareerItem(1, "Start here", "", null);
      careerDotnet.Items.Add(careerItem);

      var careers = new List<Career>();
      careers.Add(careerDotnet);

      foreach ()

    }
  }
}