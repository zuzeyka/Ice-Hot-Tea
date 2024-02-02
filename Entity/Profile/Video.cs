namespace Ice_Hot_Tea.Data.Entity.Profile
{
    public class Video
    {
        public String id { get; set; }
        public String userId { get; set; }
        public String videoUrl { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public Video(String id, String userId, String videoUrl, DateTime createdAt)
        {
            this.id = id;
            this.userId = userId;
            this.videoUrl = videoUrl;
            this.createdAt = createdAt;
        }
    }
}
