﻿using Slush.Data.Entity.Community;
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
        public List<OwnedGame> ownedGames { get; set; }
        public List<WishedGame> wishedGames { get; set; }
        public List<Friends> friends { get; set; }
        public List<UserComment> comments { get; set; }
        public List<Screenshot> screenshots { get; set; }
        public List<Video> videos { get; set; }
        public List<Group> groups { get; set; }

        public User() { }


        public User(Guid id,
                    String name,
                    String passwordSalt,
                    String email,
                    String phone,
                    List<OwnedGame> ownedGames,
                    List<WishedGame> wishedGames,
                    List<Friends> friends,
                    DateTime createdAt,
                    String salt,
                    List<Screenshot> screenshots,
                    List<Video> videos,
                    List<Group> groups)
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
