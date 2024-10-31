using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using System.Text.RegularExpressions;

    public class User
    {
        public User(string name, string surname, Gender gender, LookingFor lookingFor, byte[] profilePic)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            LookingFor = lookingFor;
            ProfilePic = profilePic;
        }

        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }

        public int? Height { get; set; }
        public int? Weight { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Gender LookingFor { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [Required]
        public byte[] ProfilePic { get; set; }

        // Navigation properties
        public ICollection<Rate> RatesFromUser { get; set; }
        public ICollection<Rate> RatesToUser { get; set; }
        public ICollection<Match> MatchesAsFirstUser { get; set; }
        public ICollection<Match> MatchesAsSecondUser { get; set; }
    }

    public enum Gender
    {
        Divers,
        Male,
        Female
    }

}
