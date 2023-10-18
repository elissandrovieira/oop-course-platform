using Balta.ContentContext;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var course = new Course();
      foreach( var i in course )
      Console.WriteLine("Hello world!");
    }
  }
}