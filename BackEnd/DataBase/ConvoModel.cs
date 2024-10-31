using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class ConvoModel
    {
        public ConvoModel(int matchID)
        {
            MatchID = matchID;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Match")]
        public int MatchID { get; set; }

        public MatchModel Match { get; set; }
        public List<Message> Messages { get; set; }
    }

}
