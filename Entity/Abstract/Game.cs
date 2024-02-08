namespace Slush.Entity.Abstract
{
    public abstract class Game : DBRecord
    {
        public String name { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public String previeImage { get; set; }
        public List<String> gameImages { get; set; }
        public DateTime dateOfRelease { get; set; }
        public String developerId { get; set; }
        public String publisherId { get; set; }
        public List<String> categoriesId { get; set; }
        public List<String> languagesId { get; set; }
        public List<String> systemRequirementsId { get; set; }
        public String urlForContent { get; set; }
    }
}
