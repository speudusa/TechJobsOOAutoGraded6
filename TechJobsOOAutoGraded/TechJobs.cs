using System;
namespace TechJobsOOAutoGraded
{
	public class TechJobs
	{
        public void RunProgram()
        {

            TechJobs job1 = new TechJobs("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJobs job2 = new TechJobs("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            TechJobs job3 = new TechJobs("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<TechJobs> jobs = new List<TechJobs>();
                jobs.Add(job1);
                jobs.Add(job2);
                jobs.Add(job3);

            foreach (TechJobs job in jobs)
            {
                Console.WriteLine(job);
            }
            
        }
    }
}

