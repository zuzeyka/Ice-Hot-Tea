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

        public Group(String id, String name, String description, List<User> users, List<Topic> topics, List<GroupComment> comments, DateTime createdAt, DateTime? deletedAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.users = users;
            this.topics = topics;
            this.comments = comments;
            this.createdAt = createdAt;
            this.deletedAt = deletedAt;
        }
    }
}
