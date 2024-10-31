using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inder.Contracts.User;

public class UserCreateDTO : IUserDTO
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }
    
    public int Height { get; set; }

    public double Weight { get; set; }

    public string Gender {  get; set; } 

    public string LookingFor { get; set; }
    
    public string Bio { get; set; }

    public byte[] ProfilePic { get; set; }
}
