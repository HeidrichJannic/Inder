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
        public async Task <IActionResult> GetAllUser([HttpTrigger(AuthorizationLevel.Function, "get", Route = "users")] HttpRequest req)
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
        public async Task<IActionResult> GetUserByID([HttpTrigger(AuthorizationLevel.Function, "get", Route = "users/{userID}")] HttpRequest req, int userID)
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

        [Function("DeleteAllUser")]
        public async Task<IActionResult> DeleteAllUsers([HttpTrigger(AuthorizationLevel.Function, "delete", Route = "users")] HttpRequest req)
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

        [Function("DeleteUserById")]
        public async Task<IActionResult> DeleteUserById([HttpTrigger(AuthorizationLevel.Function, "delete", Route = "users/{userID}")] HttpRequest req, int userID)
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
        public async Task<IActionResult> PostUser([HttpTrigger(AuthorizationLevel.Function, "post", Route = "users")] HttpRequest req)
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

        [Function("UpdateUserById")]
        public async Task<IActionResult> UpdateUserById([HttpTrigger(AuthorizationLevel.Function, "put", Route = "users/{userID}")] HttpRequest req, int userID)
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
