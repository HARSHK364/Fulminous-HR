using FM.HRMS.Models;

/*using FM.HRMS.Models.Latest;*/
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FM.HRMS
{
    public class HRDBContext : IdentityDbContext<Company>
    {

        public HRDBContext(DbContextOptions<HRDBContext> options) : base(options)
        {
        }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Company> Company { get; set; } 
        public DbSet<AddJob> JobPositions { get; set; }
        public DbSet<Round> Round { get; set; }    



 /*       public DbSet<ApplicantRounds> ApplicantRounds { get; set; }
        public DbSet<InterviewSchedules> InterviewSchedules { get; set; }*/
      
       /* public DbSet<Rounds> Rounds { get; set; }
        public DbSet<RoundType> RoundType { get; set; }*/
    }
}
