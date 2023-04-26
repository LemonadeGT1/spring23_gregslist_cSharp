
namespace gregslist_cSharp.Repositories;

public class HousesRepository
{
  private readonly IDbConnection _db;

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<House> GetAll()
  {
    string sql = "SELECT * FROM houses;";
    List<House> houses = _db.Query<House>(sql).ToList();
    return houses;
  }

  internal House GetOneById(int houseId)
  {
    string sql = "Select * FROM houses WHERE id = @houseId;";
    House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
    return house;
  }

  internal int CreateHouse(House houseData)
  {
    string sql = @"
    INSERT INTO houses (bedRooms, bathRooms, price, yearBuilt, copyText, color)
    values (@BedRooms, @BathRooms, @Price, @YearBuilt, @CopyText, @Color);
    SELECT LAST_INSERT_ID();";
    int id = _db.ExecuteScalar<int>(sql, houseData);
    return id;
  }

  internal void EditHouse(House originalHouse)
  {
    string sql = @"
    UPDATE houses
    SET
    bedRooms = @BedRooms,
    bathRooms = @BathRooms,
    price = @Price,
    yearBuilt = @YearBuilt,
    copyText = @CopyText,
    color = @Color
    ;";
    _db.Execute(sql, originalHouse);
  }

  internal int RemoveHouse(int houseId)
  {
    string sql = "DELETE FROM houses WHERE id = @houseId;";
    int rowsAffected = _db.Execute(sql, new { houseId });
    return rowsAffected;
  }

}
