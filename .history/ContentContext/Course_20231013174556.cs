namespace Balta.ContentContext
{
  public class Course : Content
  {
    public Course()
    {
      Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
  }

  public class Module
  {
    public int Order { get; set; }
    public string Title { get; set; }
    public 
  }

  public class Lecture
  {
    public int  Order {get; set; }
    public string Title {get; set; }
  }
}