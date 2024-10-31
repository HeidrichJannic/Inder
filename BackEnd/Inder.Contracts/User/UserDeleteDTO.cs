using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inder.Contracts.User
{
    public  class UserDeleteDTO : IUserDTO
    {
        public string UserId { get; set; } 
    }
}
