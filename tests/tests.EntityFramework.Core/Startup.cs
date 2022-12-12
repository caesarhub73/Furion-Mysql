using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace tests.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "tests.Database.Migrations");
        }
    }
}