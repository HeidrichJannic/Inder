using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Inder.Api.Core.Repository;
using Inder.Contracts.User;
using Newtonsoft.Json;

namespace Inder.API.Core.Functions
{
    public class UserFunctions
    {
        private readonly IRepository<IUserDTO> _userRepository;
        private readonly ILogger<UserFunctions> _logger;

        public UserFunctions(ILogger<UserFunctions> logger, IRepository<IUserDTO> userRepository)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [Function("GetAllUser")]
        public async Task <IActionResult> GetAllUser([HttpTrigger(AuthorizationLevel.Function, "get", Route = "user")] HttpRequest req)
        {
            try
            {
                _logger.LogInformation("C# HTTP trigger function processed a request.");
                List<UserDTO> response = (List<UserDTO>)_userRepository.GetAll();
                return new OkObjectResult(response);
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
                UserDTO response = (UserDTO)_userRepository.GetById(userId);
                return new OkObjectResult(response);
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
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

                if (string.IsNullOrEmpty(requestBody))
                {
                    return new StatusCodeResult(StatusCodes.Status400BadRequest);
                }
                else
                {
                    UserCreateDTO userCreateDTO = JsonConvert.DeserializeObject<UserCreateDTO>(requestBody);

                    _userRepository.Add(userCreateDTO);

                    return new StatusCodeResult(StatusCodes.Status201Created);
                }
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.ToString());
            }
        }
    }
}
