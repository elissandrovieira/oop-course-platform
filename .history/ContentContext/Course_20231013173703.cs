namespace Balta.ContentContext
{
  public class Course : Content
  {
    public string Tag { get; set; }
    public List<Module> MyProperty { get; set; }
  }

  public class Module
  {

  }
}