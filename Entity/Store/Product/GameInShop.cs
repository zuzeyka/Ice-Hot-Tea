using Slush.Data.Entity;
using Slush.Entity.Abstract;

namespace Slush.Entity.Store.Product
{
    public class GameInShop
    {
        public String id { get; set; }
        public String name { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public String previeImage { get; set; }
        public DateTime dateOfRelease { get; set; }
        public String developerId { get; set; }
        public String publisherId { get; set; }
        public String urlForContent { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public virtual List<String> categoriesId { get; set; }           = null!;
        public virtual List<String> gameImages { get; set; }           = null!;
        public virtual List<LanguageInGame> languages { get; set; }    = null!;
        public virtual List<String> languagesId { get; set; }          = null!;
        public virtual List<String> systemRequirementsId { get; set; } = null!;
    }
}
