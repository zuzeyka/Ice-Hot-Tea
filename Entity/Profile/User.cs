using Ice_Hot_Tea.Data.Entity.Community;
using Ice_Hot_Tea.Entity.Store.Product;

namespace Ice_Hot_Tea.Data.Entity.Profile
{
    public class User
    {
        public String id { get;set; }
        public String name { get;set; }
        public String passwordSalt { get;set; }
        public String salt { get;set; }
        public String email { get;set; }
        public String phone { get;set; }
        public List<GameInShop> ownedGames { get; set; }
        public List<GameInShop> wishedGames { get; set; }
        public List<User> friends { get; set; }
        public List<UserComment> comments { get; set; }
        public List<Screenshot> screenshots { get; set; }
        public List<Video> videos { get; set; }
        public List<Group> groups { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public User(String id, String name, String passwordSalt, String email, String phone, List<GameInShop> ownedGames, List<GameInShop> wishedGames,
                    List<User> friends, DateTime createdAt, String salt, List<Screenshot> screenshots, List<Video> videos, List<Group> groups)
        {
            this.id = id;
            this.name = name;
            this.passwordSalt = passwordSalt;
            this.email = email;
            this.phone = phone;
            this.ownedGames = ownedGames;
            this.wishedGames = wishedGames;
            this.friends = friends;
            this.createdAt = createdAt;
            this.salt = salt;
            this.screenshots = screenshots;
            this.videos = videos;
            this.groups = groups;
        }
    }
}
