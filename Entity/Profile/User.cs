using Slush.Data.Entity.Community;
using Slush.Entity.Abstract;
using Slush.Entity.Profile;
using Slush.Entity.Store.Product;

namespace Slush.Data.Entity.Profile
{
    public class User : DBRecord
    {
        public String name { get;set; }
        public String passwordSalt { get;set; }
        public String salt { get;set; }
        public String email { get;set; }
        public String phone { get;set; }


        public User(String id,
                    String name,
                    String passwordSalt,
                    String email,
                    String phone,
                    DateTime createdAt,
                    String salt)
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


        public List<OwnedGame> ownedGames { get; set; }     = null!;
        public List<WishedGame> wishedGames { get; set; }   = null!;
        public List<Friends> friends { get; set; }          = null!;
        public List<UserComment> comments { get; set; }     = null!;
        public List<Screenshot> screenshots { get; set; }   = null!;
        public List<Video> videos { get; set; }             = null!;
        public List<Group> groups { get; set; } = null!;
    }
}
