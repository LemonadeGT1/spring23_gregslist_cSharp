namespace gregslist_cSharp.Services;

public class HousesService
{
  private readonly HousesRepository _housesRepo;

  public HousesService(HousesRepository housesRepo)
  {
    _housesRepo = housesRepo;
  }

  internal List<House> GetAll()
  {
    List<House> houses = _housesRepo.GetAll();
    return houses;
  }

  internal House GetOneById(int houseId)
  {
    House house = _housesRepo.GetOneById(houseId);
    if (house == null)
    {
      throw new Exception($"This id is invalid: {houseId}");
    }
    return house;
  }

  internal House CreateHouse(House houseData)
  {
    int id = _housesRepo.CreateHouse(houseData);
    House house = this.GetOneById(id);
    return house;
  }

  internal House EditHouse(House houseData, int houseId)
  {
    House originalHouse = this.GetOneById(houseId);
    originalHouse.BedRooms = houseData.BedRooms ?? originalHouse.BedRooms;
    originalHouse.BathRooms = houseData.BathRooms ?? originalHouse.BathRooms;
    originalHouse.YearBuilt = houseData.YearBuilt ?? originalHouse.YearBuilt;
    originalHouse.Price = houseData.Price ?? originalHouse.Price;
    originalHouse.CopyText = houseData.CopyText ?? originalHouse.CopyText;
    originalHouse.Color = houseData.Color ?? originalHouse.Color;
    _housesRepo.EditHouse(originalHouse);

    originalHouse.UpdatedAt = DateTime.Now;

    return originalHouse;
  }

  internal string RemoveHouse(int houseId)
  {
    House house = this.GetOneById(houseId);
    int rowsAffected = _housesRepo.RemoveHouse(houseId);
    return $"House with id:{house.Id} has been SOLD!";
  }
}
