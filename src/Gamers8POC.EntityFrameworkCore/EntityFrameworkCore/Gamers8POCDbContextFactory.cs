using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Gamers8POC.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Gamers8POCDbContextFactory : IDesignTimeDbContextFactory<Gamers8POCDbContext>
{
    public Gamers8POCDbContext CreateDbContext(string[] args)
    {
        Gamers8POCEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Gamers8POCDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Gamers8POCDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Gamers8POC.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
