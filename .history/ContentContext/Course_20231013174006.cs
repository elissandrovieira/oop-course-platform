namespace Balta.ContentContext
{
  public class Course : Content
  {
    public Course()
    {
      Modules = new List
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
  }

  public class Module
  {

  }
}