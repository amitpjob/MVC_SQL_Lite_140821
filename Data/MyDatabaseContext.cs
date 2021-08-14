using Microsoft.EntityFrameworkCore;
using DotNetAzure.Models;

namespace DotNetAzure.Data
{
public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetAzure.Models.Todo> Todo { get; set; }
    }
}