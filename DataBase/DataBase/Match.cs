using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Match
    {
        public Match(int firstUserId, int secondUserId)
        {
            FirstUserId = firstUserId;
            SecondUserId = secondUserId; 
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("FirstUser")]
        public int FirstUserId { get; set; }

        [ForeignKey("SecondUser")]
        public int SecondUserId { get; set; }

        // Navigation properties
        public User FirstUser { get; set; }
        public User SecondUser { get; set; }

        public Convo Convo { get; set; }
    }

}
