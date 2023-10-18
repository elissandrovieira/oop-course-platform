namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career()
    {
      Items = new IList<CareerItem>;
    }
    public IList<CareerItem> Items { get; set; }
  }

  public class CareerItem
  {
    public int Order { get; set; }
    public string Title {get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}