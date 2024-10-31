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

        [Function("GetAllUser")]
        public async Task <IActionResult> GetAllUser([HttpTrigger(AuthorizationLevel.Function, "get", Route = "user")] HttpRequest req)
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

        [Function("GetUserByID")]
        public async Task<IActionResult> GetUserById([HttpTrigger(AuthorizationLevel.Function, "get", Route = "user/{userID}")] HttpRequest req, int userId)
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

        [Function("PostUser")]
        public async Task<IActionResult> PostUser([HttpTrigger(AuthorizationLevel.Function, "post", Route = "user")] HttpRequest req)
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
