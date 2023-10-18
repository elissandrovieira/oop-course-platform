﻿using Platform.ContentContext;
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

      var courses = new List<Course>();

      var courseOop = new Course("OOP fundamentals", "oop-fundamentals");
      var courseCsharp = new Course("C# fundamentals", "csharp-fundamentals");
      var courseAspnet = new Course("ASP.NET fundamentals", "aspnet-fundamentals");

      courses.Add(courseOop);
      courses.Add(courseCsharp);
      courses.Add(courseAspnet);

      var careerDotnet = new Career(".Net specialist", "dotnet-specialist");
      var careerItem1 = new CareerItem(1, courseOop., "", courseOop);
      var careerItem2 = new CareerItem(2, courseCsharp.Title, "", courseCsharp);
      var careerItem3 = new CareerItem(3, courseAspnet.Title, "", courseAspnet);
      careerDotnet.Items.Add(careerItem1);
      careerDotnet.Items.Add(careerItem2);
      careerDotnet.Items.Add(careerItem3);

      var careers = new List<Career>();
      careers.Add(careerDotnet);

      foreach(var career in careers)
      {
        Console.WriteLine(career.Title);
        foreach(var item in career.Items.OrderBy(x=> x.Order))
        {
          Console.WriteLine($"{item.Order} - {item.Title}");
        }
      }

    }
  }
}