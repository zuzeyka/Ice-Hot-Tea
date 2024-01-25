using Ice_Hot_Tea.Entity.Store.Product;
using Ice_Hot_Tea.Entity.Store.Product.Categories;
using Ice_Hot_Tea.Entity.Store.Product.Language;
using Ice_Hot_Tea.Entity.Store.Product.Requirements;

namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Game
    {
        protected string id { get; set; }
        protected string name { get; set; }
        protected float price { get; set; }
        protected string image { get; set; }
        protected DateTime dateOfRelease { get; set; }
        protected Author author { get; set; }
        protected Publisher publisher { get; set; }
        protected List<CategoryForGame> categories { get; set; }
        protected List<LanguageInGame> languages { get; set; }
        protected List<SystemRequirement> systemRequirements { get; set; }
        protected string urlForContent { get; set; }
        protected DateTime createdAt { get; set; }
        protected DateTime? deleteAt { get; set; }
    }
}
