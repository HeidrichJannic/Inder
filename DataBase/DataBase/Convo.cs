using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Convo
    {
        public Convo(int matchID)
        {
            MatchID = matchID;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Match")]
        public int MatchID { get; set; }

        public Match Match { get; set; }
        public List<Message> Messages { get; set; }
    }

}
