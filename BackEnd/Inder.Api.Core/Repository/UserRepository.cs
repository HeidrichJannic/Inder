using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inder.Contracts.User;
using Newtonsoft.Json;

namespace Inder.Api.Core.Repository
{
    public class UserRepository : IRepository<IUserDTO>
    {
        public void Add(IUserDTO tempCreateUserDTO)
        {
            UserCreateDTO userData = (UserCreateDTO)tempCreateUserDTO;

            UserDTO userDTO = new UserDTO()
            {
                Age = userData.Age,
                Bio = userData.Bio,
                Gender = userData.Gender,
                Height = userData.Height,
                LookingFor = userData.LookingFor,
                Name = userData.Name,
                ProfilePicture = userData.ProfilePicture,
                Surname = userData.Surname,
                Weight = userData.Weight,
                Id = 0
            };
        }

        public IEnumerable<IUserDTO> GetAll()
        {
            List<UserModel> userModel = _dbContext.User.ToList();
            List<UserDTO> users = new List<UserDTO>();
            users = userModel;
            return users;
        }

        public IUserDTO GetById(int Id)
        {
            string userJsonFormat = JsonConvert.SerializeObject(_dbContext.User.Where(element => element.Id == Id).Select(i => i).FirstOrDefault());
            UserDTO userDTO = JsonConvert.DeserializeObject<UserModel>(userJsonFormat)!;

            throw new NotImplementedException();
        }
    }
}
