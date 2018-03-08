using System.Data.Entity;
using HelloOData.Models;

namespace HelloOData
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DatabaseContext")
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
