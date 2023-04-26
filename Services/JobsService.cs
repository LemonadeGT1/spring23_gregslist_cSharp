namespace gregslist_cSharp.Services;

public class JobsService
{
  private readonly JobsRepository _jobsRepo;

  public JobsService(JobsRepository jobsRepo)
  {
    _jobsRepo = jobsRepo;
  }

  internal List<Job> GetAll()
  {
    List<Job> jobs = _jobsRepo.GetAll();
    return jobs;
  }
}
