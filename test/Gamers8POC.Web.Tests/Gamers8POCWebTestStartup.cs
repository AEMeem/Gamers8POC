using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Gamers8POC;

public class Gamers8POCWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<Gamers8POCWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
