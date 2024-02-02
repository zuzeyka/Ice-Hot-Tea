namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class ProfileGame
    {
        public String id { get; set; }
        public String ownedGameId { get; set; }
        public String userId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }
    }
}
