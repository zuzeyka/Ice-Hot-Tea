using Slush.Data.Entity;
using Slush.Entity.Abstract;

namespace Slush.Entity.Store.Product
{
    public class GameInShop : Game
    {
        public GameInShop(String id,
                          String name,
                          float price,
                          int discount,
                          String image,
                          DateTime dateOfRelease,
                          String author,
                          String publisher,
                          List<String> categories,
                          List<String> gameImages,
                          List<LanguageInGame> languages,
                          String urlForContent,
                          DateTime createdAt,
                          List<String> languagesId,
                          List<String> systemRequirementsId)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discount = discount;
            this.gameImages = gameImages;
            this.previeImage = image;
            this.dateOfRelease = dateOfRelease;
            this.languagesId = languagesId;
            this.developerId = author;
            this.publisherId = publisher;
            this.categoriesId = categories;
            this.systemRequirementsId = systemRequirementsId;
            this.urlForContent = urlForContent;
            this.createdAt = createdAt;
        }
    }
}
