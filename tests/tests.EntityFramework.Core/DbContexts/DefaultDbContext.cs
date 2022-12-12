using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace tests.EntityFramework.Core
{
    [AppDbContext("AADConnection", DbProvider.MySql)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}