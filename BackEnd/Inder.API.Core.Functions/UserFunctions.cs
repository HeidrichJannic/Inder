using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Inder.API.Core.Functions
{
    public class UserFunctions
    {
        private readonly ILogger<UserFunctions> _logger;

        public UserFunctions(ILogger<UserFunctions> logger)
        {
            _logger = logger;
        }

        [Function("GetUser")]
        public IActionResult GetUser([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            try
            {
                _logger.LogInformation("C# HTTP trigger function processed a request.");
                return new OkObjectResult("Welcome to Azure Functions!");
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.ToString());
            }
        }
    }
}
