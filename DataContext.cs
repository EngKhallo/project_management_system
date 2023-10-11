using Microsoft.EntityFrameworkCore;

namespace ProjectMgtSystemApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        
    }
}