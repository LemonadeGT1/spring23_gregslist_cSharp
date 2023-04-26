
namespace gregslist_cSharp.Models;

public class House
{
  public int Id { get; set; }
  public int? BedRooms { get; set; }
  public int? BathRooms { get; set; }
  public int? Price { get; set; }
  public int? YearBuilt { get; set; }
  public string CopyText { get; set; }
  public string Color { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
