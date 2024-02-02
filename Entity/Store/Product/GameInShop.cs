using Ice_Hot_Tea.Data.Entity;
using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product
{
    public class GameInShop : Game
    {
        public GameInShop(String id, String name, float price, String image, DateTime dateOfRelease,
                         String author, String publisher, List<String> categories,
                         List<LanguageInGame> languages, String urlForContent, DateTime createdAt)
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
        }
    }
}
