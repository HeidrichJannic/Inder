namespace Inder.Contracts.User
{
    public class UserDTO : IUserDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        public double Weight { get; set; }

        public string Gender { get; set; }

        public string LookingFor { get; set; }

        public string Bio { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}
