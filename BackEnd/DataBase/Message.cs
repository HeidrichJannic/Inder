using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class Message
    {
        public Message(int convoID,int fromUserId, string text, DateTime dateTime)
        {
            ConvoID = convoID;
            FromUserId = fromUserId;
            Text = text;
            DateTime = dateTime;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Convo")]
        public int ConvoID { get; set; }

        [ForeignKey("FromUser")]
        public int FromUserId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public ConvoModel Convo { get; set; }
        public UserModel FromUser { get; set; }
    }
}
