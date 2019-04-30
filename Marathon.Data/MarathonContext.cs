using Marathon.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Marathon.Data
{
    public  class MarathonContext:DbContext
    {
        MarathonContext(DbContextOptions<MarathonContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
