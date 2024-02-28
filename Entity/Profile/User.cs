using Slush.Data.Entity.Community;
using Slush.Entity.Abstract;
using Slush.Entity.Profile;
using Slush.Entity.Store.Product;

namespace Slush.Data.Entity.Profile
{
    public class User 
    {
        public String id { get; set; }
        public String name { get;set; }
        public String passwordSalt { get;set; }
        public String salt { get;set; }
        public String email { get;set; }
        public String phone { get;set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public virtual List<OwnedGame> ownedGames { get; set; }     = null!;
        public virtual List<WishedGame> wishedGames { get; set; }   = null!;
        public virtual List<Friends> friends { get; set; }          = null!;
        public virtual List<UserComment> comments { get; set; }     = null!;
        public virtual List<Screenshot> screenshots { get; set; }   = null!;
        public virtual List<Video> videos { get; set; }             = null!;
        public virtual List<Group> groups { get; set; } = null!;
    }
}
