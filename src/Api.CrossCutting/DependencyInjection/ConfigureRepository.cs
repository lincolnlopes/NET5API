using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceColletion)
        {
            const string connectionString = "Server=127.0.0.1;Database=Course;Uid=root; Pwd=123456";
            serviceColletion.AddDbContext<MyContext>(
                    options =>
                        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            serviceColletion.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}