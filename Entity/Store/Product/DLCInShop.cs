using Slush.Data.Entity;
using Slush.Entity.Abstract;

namespace Slush.Entity.Store.Product
{
    public class DLCInShop : Game
    {
        public String gameId;
        public DLCInShop() { }
        public DLCInShop(Guid id,
                         String name,
                         float price,
                         String image,
                         DateTime dateOfRelease,
                         String author,
                         String publisher,
                         List<String> categories,
                         List<LanguageInGame> languages,
                         String urlForContent,
                         DateTime createdAt,
                         String gameId)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.previeImage = image;
            this.dateOfRelease = dateOfRelease;
            this.developerId = author;
            this.publisherId = publisher;
            this.categoriesId = categories;
            this.urlForContent = urlForContent;
            this.createdAt = createdAt;
            this.gameId = gameId;
        }
    }
}
