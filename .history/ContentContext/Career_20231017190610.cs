namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career(IList<CareerItem> Item)
    {
      Items = Item;
    }
    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}