using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace tests.EntityFramework.Core
{
    [AppDbContext("AADConnection", $"{DbProvider.MySql}@5.7.32")]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}