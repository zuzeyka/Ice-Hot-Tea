using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community
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
