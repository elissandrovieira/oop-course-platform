using System.Globalization;

namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career(IList<CalendarWeekRule]>)
    {
      Items = new List<CareerItem>();
    }
    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}