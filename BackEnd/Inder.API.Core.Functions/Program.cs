using Inder.Api.Core.Repository;
using Inder.Contracts.User;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();


        services.AddSingleton<IRepository<IUserDTO>, UserRepository>();
    })
    .Build();

host.Run();