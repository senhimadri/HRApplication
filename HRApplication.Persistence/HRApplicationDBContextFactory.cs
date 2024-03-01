using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HRApplication.Persistence;

public class HRApplicationDBContextFactory : IDesignTimeDbContextFactory<HRApplicationDBContext>
{
    public HRApplicationDBContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

        var builder = new DbContextOptionsBuilder<HRApplicationDBContext>();

        var connectionString = configuration.GetConnectionString("HRApplicationConnectionString");

        builder.UseSqlServer(connectionString);

        return new HRApplicationDBContext(builder.Options);
    }
}

