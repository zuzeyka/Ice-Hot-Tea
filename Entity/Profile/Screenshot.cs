namespace Ice_Hot_Tea.Data.Entity.Profile
{
    public class Screenshot
    {
        public String id {  get; set; }
        public String userId { get; set; }
        public String screenshotUrl { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public Screenshot(String id, String userId, String screenshotUrl, DateTime createdAt)
        {
            this.id = id;
            this.userId = userId;
            this.screenshotUrl = screenshotUrl;
            this.createdAt = createdAt;
        }
    }
}
