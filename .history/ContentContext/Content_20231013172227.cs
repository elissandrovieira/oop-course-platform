using System.Data.Common;

namespace Balta.ContentContext
{
  public class Content
  {
    public Content()
    {
      Id = Guid
    }
    public int Guid { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}