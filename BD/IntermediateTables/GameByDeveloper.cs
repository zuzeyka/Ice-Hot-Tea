using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class GameByDeveloper : BDRecord
    {
        public string gameId { get; set; }
        public string developerId { get; set; }
        public string publisherId { get; set; }
    }
}
