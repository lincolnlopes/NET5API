using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext()
        {
            return CreateDbContext(null);
        }
        public MyContext CreateDbContext(string[] args)
        {
            const string connectionString = "Server=127.0.0.1;Database=Course;Uid=root; Pwd=123456";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            return new MyContext(optionsBuilder.Options);
        }
    }
}