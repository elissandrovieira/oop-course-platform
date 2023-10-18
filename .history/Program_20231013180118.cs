using Balta.ContentContext;
using Balta.ContentContext.Enums;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var course = new Course();
      course.Level = EcontentLevel.Beginner;
      Console.WriteLine("Hello world!");
    }
  }
}