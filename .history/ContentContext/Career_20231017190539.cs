namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career(IList<CareerItem>)
    {
      Items = new List<CareerItem>();
    }
    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}