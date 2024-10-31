using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inder.Contracts.User;

namespace Inder.Api.Core.Repository
{
    internal class UserRepository : IRepository<IUserDTO>
    {
        public void CreateUser(IUserDTO tempCreateUserDTO)
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
    }
}
