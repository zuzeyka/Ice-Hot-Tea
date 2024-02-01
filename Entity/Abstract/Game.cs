namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Game : BDRecord
    {
        public string name { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public string previeImage { get; set; }
        public List<string> gameImages { get; set; }
        public DateTime dateOfRelease { get; set; }
        public string developerId { get; set; }
        public string publisherId { get; set; }
        public List<string> categoriesId { get; set; }
        public List<string> languagesId { get; set; }
        public List<string> systemRequirementsId { get; set; }
        public string urlForContent { get; set; }
    }
}
