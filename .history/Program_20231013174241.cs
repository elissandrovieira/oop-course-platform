﻿using Balta.ContentContext;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var course = new Course();
      Console.WriteLine("Hello world!");
      foreach( var i in course.Modules);
    }
  }
}