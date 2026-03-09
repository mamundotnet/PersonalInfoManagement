using Microsoft.EntityFrameworkCore;
using PersonalInfoManagement.Models.DbModels;

namespace PersonalInfoManagement.Models.dbContextClass
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalInfo> PersonalInfos { get; set; }
    }
}
