using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Slush.Data.Entity.Community.GameGroup;
using Slush.Data.Entity.Community;
using Slush.Entity.Profile;
using Slush.Data.Entity.Profile;
using Slush.Data.Entity;
using Slush.Entity.Store.Product.Creators;
using Slush.Entity.Store.Product;

namespace Slush.Data
{
    public class DataContext : DbContext
    {
        public DbSet<GameGroup>                dbGameGroups                { get; set; }
        public DbSet<GameComment>              dbGameComments              { get; set; }
        public DbSet<GameGuide>                dbGameGuides                { get; set; }
        public DbSet<GameNews>                 dbGameNews                  { get; set; }
        public DbSet<GamePosts>                dbGamePosts                 { get; set; }
        public DbSet<GameTopic>                dbGameTopics                { get; set; }

        public DbSet<Group>                    dbGroups                    { get; set; }
        public DbSet<GroupComment>             dbGroupComments             { get; set; }
        public DbSet<Post>                     dbPosts                     { get; set; }
        public DbSet<Topic>                    dbTopics                    { get; set; }

        public DbSet<Friends>                  dbFriends                   { get; set; }
        public DbSet<Video>                    dbVideos                    { get; set; }
        public DbSet<Screenshot>               dbScreenshots               { get; set; }
        public DbSet<User>                     dbUsers                     { get; set; }
        public DbSet<UserComment>              dbUserComments              { get; set; }
        public DbSet<OwnedGame>                dbOwnedGames                { get; set; }
        public DbSet<WishedGame>               dbWishedGames               { get; set; }

        public DbSet<Categories>               dbCategories                { get; set; }
        public DbSet<CategoryByAuthor>         dbCategoriesByAuthors       { get; set; }
        public DbSet<CategoryByUser>           dbCategoriesByUsers         { get; set; }
        public DbSet<CategoryForGame>          dbCategoriesForGame         { get; set; }

        public DbSet<Developer>                dbDevelopers                { get; set; }
        public DbSet<Publisher>                dbPublishers                { get; set; }

        public DbSet<Language>                 dbLanguages                 { get; set; }
        public DbSet<LanguageInGame>           dbLanguagesInGame           { get; set; }

        public DbSet<MaximumSystemRequirement> dbMaximumSystemRequirements { get; set; }
        public DbSet<MinimalSystemRequirement> dbMinimalSystemRequirements { get; set; }
        public DbSet<SystemRequirement>        dbSystemRequirements        { get; set; }

        public DbSet<DLCInShop>                dbDLCsInShop                { get; set; }
        public DbSet<GameInShop>               dbGamesInShops              { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List<object>>().HasNoKey();
        }
    }
}
