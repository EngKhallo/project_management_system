using Microsoft.EntityFrameworkCore;
using ProjectMgtSystemApi.Models;

namespace ProjectMgtSystemApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Users> Users => Set<Users>();
        public DbSet<Projects> Projects => Set<Projects>();
        public DbSet<Tasks> Tasks => Set<Tasks>();
    }
}