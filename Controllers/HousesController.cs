namespace gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{
  private readonly HousesService _housesService;

  public HousesController(HousesService housesService)
  {
    _housesService = housesService;
  }

  [HttpGet]
  public ActionResult<List<House>> GetAll()
  {
    try
    {
      List<House> houses = _housesService.GetAll();
      return Ok(houses);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{houseId}")]
  public ActionResult<House> GetOneById(int houseId)
  {
    try
    {
      House house = _housesService.GetOneById(houseId);
      return Ok(house);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<House> CreateHouse([FromBody] House houseData)
  {
    try
    {
      House house = _housesService.CreateHouse(houseData);
      return Ok(house);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{houseId}")]
  public ActionResult<House> EditHouse([FromBody] House houseData, int houseId)
  {
    try
    {
      House house = _housesService.EditHouse(houseData, houseId);
      return Ok(house);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{houseId}")]
  public ActionResult<string> RemoveHouse(int houseId)
  {
    try
    {
      string message = _housesService.RemoveHouse(houseId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
