using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class LanguageInGame : DBRecord
    {
        public String gameId { get; set; }
        public String languageId { get; set; }
        public LanguageInGame(String id,
                              String gameId,
                              String languageId,
                              DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.languageId = languageId;
            this.createdAt = createdAt;
        }
    }
}
