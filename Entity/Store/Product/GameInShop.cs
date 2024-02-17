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
                          String urlForContent,
                          DateTime createdAt)
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


        List<String> categories { get; set; }           = null!;
        List<String> gameImages { get; set; }           = null!;
        List<LanguageInGame> languages { get; set; }    = null!;
        List<String> languagesId { get; set; }          = null!;
        List<String> systemRequirementsId { get; set; } = null!;
    }
}
