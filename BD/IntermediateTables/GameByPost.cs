using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class GameByPost : DBRecord
    {
        public string gameId {  get; set; }
        public string postId { get; set; }
    }
}
