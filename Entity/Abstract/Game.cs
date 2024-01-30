using Ice_Hot_Tea.Entity.Store.Product;
using Ice_Hot_Tea.Entity.Store.Product.Language;
using Ice_Hot_Tea.Entity.Store.Product.Requirements;

namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Game
    {
        public string id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public string previeImage { get; set; }
        public List<string> gameImages { get; set; }
        public DateTime dateOfRelease { get; set; }
        public string developerId { get; set; }
        public string publisherId { get; set; }
        public List<Category> categories { get; set; }
        public List<Language> languages { get; set; }
        public List<SystemRequirement> systemRequirements { get; set; }
        public string urlForContent { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
