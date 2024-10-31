using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Inder.API.Core;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {   
        //AutoMapper
        services.AddMapper(entity => entity.AddProfile<MapperService>(), AppDomain.CurrentDomain.GetAssemblies());

        

        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    
    .Build();
host.Run();