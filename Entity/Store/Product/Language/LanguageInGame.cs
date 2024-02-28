using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class LanguageInGame
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String languageId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
