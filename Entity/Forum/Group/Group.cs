using Ice_Hot_Tea.Data.Entity.Profile;
using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class Group : Category
    {
        public List<User> users { get; set; }
        public List<Topic> topics { get; set; }
        public List<GroupComment> comments { get; set; }


        public Group(String id, String name, String description, List<User> users, List<Topic> topics, List<GroupComment> comments, DateTime createdAt, DateTime? deleteAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.users = users;
            this.topics = topics;
            this.comments = comments;
            this.createdAt = createdAt;
            this.deleteAt = deleteAt;
        }
    }
}
