using WebApplication1.Data.Entitty.Profile;

namespace WebApplication1.Data.Entitty.Community
{
    public class Group
    {
        public String id {  get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public List<User> users { get; set; }
        public List<Topic> topics { get; set; }
        public List<GroupComment> comments { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }
    }
}
