namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career(string title, string url)
      :base()
    {
      Items = new List<CareerItem>();
    }
    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}