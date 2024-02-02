namespace Ice_Hot_Tea.Data.Entity
{
    public class LanguageInGame
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String languageId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public LanguageInGame(String id, String gameId, String languageId, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.languageId = languageId;
            this.createdAt = createdAt;
        }
    }
}
