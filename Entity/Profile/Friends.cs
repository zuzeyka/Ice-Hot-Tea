namespace Slush.Entity.Profile
{
    public class Friends
    {
        public String id { get; set; }
        public String userId { get; set; }
        public String friendId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
