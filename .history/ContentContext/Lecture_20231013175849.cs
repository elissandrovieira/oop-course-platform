using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
  public class Lecture
  {
    public int  Order {get; set; }
    public string Title {get; set; }
    public int DurationInMinutes {get; set; }

    public EcontentLevel Level { }
  }
}