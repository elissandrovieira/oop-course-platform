using System.Data.Common;

namespace Balta.ContentContext
{

  public Content()
  {
    Id = Guid.NewGuid
  }

  public class Content
  {
    public int Guid { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}