using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class GameByRequirements : DBRecord
    {
        public string recomendedRequirementsId { get; set; }
        public string minimalRequirementsId { get; set; }
    }
}
