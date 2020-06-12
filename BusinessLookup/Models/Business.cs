namespace BusinessLookup.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string OpeningTime { get; set; }
    public string ClosingTime { get; set; }
  }
}