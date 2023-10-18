namespace Balta.ContentContext
{
  public class Career : Content
  {
    public int Courses { get; set; }
  }

  public class CareerItem
  {
    public int Order { get; set; }
    public string Title {get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}