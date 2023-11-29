using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Db.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = ConnectionStringManagerNew.GetConnectionString();
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
