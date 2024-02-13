namespace Slush.Entity.Profile
{
    public class Friends
    {
        public Guid id { get; set; }
        public String userId { get; set; }
        public String friendId { get; set; }

        public Friends() { }

        public Friends(Guid id,
                       String userId,
                       String friendId)
        {
            this.id = id;
            this.userId = userId;
            this.friendId = friendId;
        }
    }
}
