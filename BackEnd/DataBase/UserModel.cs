﻿namespace DataBase
{
    using System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        public UserModel(string name, string surname, Gender gender, string profilePic)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
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
        public string ProfilePic { get; set; }

        // Navigation properties
        public ICollection<RateModel> RatesFromUser { get; set; }
        public ICollection<RateModel> RatesToUser { get; set; }
        public ICollection<MatchModel> MatchesAsFirstUser { get; set; }
        public ICollection<MatchModel> MatchesAsSecondUser { get; set; }
    }

    public enum Gender
    {
        Divers,
        Male,
        Female
    }

}
