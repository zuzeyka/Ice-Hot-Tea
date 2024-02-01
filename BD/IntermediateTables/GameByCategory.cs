using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class GameByCategory : BDRecord
    {
        public string gameId { get; set; }
        public string categoryId { get; set; }
    }
}
