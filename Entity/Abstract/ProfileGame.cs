namespace Slush.Entity.Abstract
{
    public abstract class ProfileGame : DBRecord
    {
        public String ownedGameId { get; set; }
        public String userId { get; set; }
    }
}
