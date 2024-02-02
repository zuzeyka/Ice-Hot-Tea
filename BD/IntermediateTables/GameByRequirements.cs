using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class GameByRequirements : DBRecord
    {
        public string recomendedRequirementsId { get; set; }
        public string minimalRequirementsId { get; set; }
    }
}
