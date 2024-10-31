using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inder.Contracts.User;
using Newtonsoft.Json;
using DataBase;

namespace Inder.Api.Core.Repository;

public class UserRepository : IRepository<IUserDTO>
{
    private readonly InderDbContext _dbContext;
    public UserRepository(InderDbContext dbContext)
    {
        _dbContext = dbContext;
    }
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
        string userJsonFormat = JsonConvert.SerializeObject(_dbContext.Users.ToList());
        List<UserDTO> userDTO = JsonConvert.DeserializeObject<List<UserDTO>>(userJsonFormat)!;

        return userDTO;
    }

    public IUserDTO GetById(int Id)
    {
        string userJsonFormat = JsonConvert.SerializeObject(_dbContext.Users.Where(element => element.ID == Id).Select(i => i).FirstOrDefault());
        UserDTO userDTO = JsonConvert.DeserializeObject<UserDTO>(userJsonFormat)!;

        return userDTO; 
    }
}
