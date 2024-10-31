using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Rate
    {
        public Rate(int fromUserId, int toUserId, bool like)
        {
            FromUserId = fromUserId;
            ToUserId = toUserId;
            Like = like;
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("FromUser")]
        public int FromUserId { get; set; }

        [Required]
        [ForeignKey("ToUser")]
        public int ToUserId { get; set; }

        [Required]
        public bool Like { get; set; }

        public User FromUser { get; set; }
        public User ToUser { get; set; }
    }

}
