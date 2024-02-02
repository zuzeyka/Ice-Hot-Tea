namespace Ice_Hot_Tea.Entity.Profile
{
    public class Friends
    {
        public String id { get; set; }
        public String userId { get; set; }
        public String friendId { get; set; }

        public Friends(String id, String userId, String friendId)
        {
            this.id = id;
            this.userId = userId;
            this.friendId = friendId;
        }
    }
}
