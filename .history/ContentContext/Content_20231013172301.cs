using System.Data.Common;

namespace Balta.ContentContext
{
  public class Content
  {
    public Content()
    {
      Id = Guid.NewGuid;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}