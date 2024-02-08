using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class GameByCategory : DBRecord
    {
        public string gameId { get; set; }
        public string categoryId { get; set; }
    }
}
