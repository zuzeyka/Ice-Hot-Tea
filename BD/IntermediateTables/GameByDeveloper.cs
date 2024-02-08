using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class GameByDeveloper : DBRecord
    {
        public string gameId { get; set; }
        public string developerId { get; set; }
        public string publisherId { get; set; }
    }
}
