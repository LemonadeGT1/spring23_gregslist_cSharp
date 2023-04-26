namespace gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
  private readonly JobsService _jobsService;

  public JobsController(JobsService jobsService)
  {
    _jobsService = jobsService;
  }

  [HttpGet]
  public ActionResult<List<Job>> GetAll()
  {
    try
    {
      List<Job> jobs = _jobsService.GetAll();
      return Ok(jobs);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
