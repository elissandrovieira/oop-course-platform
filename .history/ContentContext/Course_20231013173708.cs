namespace Balta.ContentContext
{
  public class Course : Content
  {
    public string Tag { get; set; }
    public IList<Module> MyProperty { get; set; }
  }

  public class Module
  {

  }
}