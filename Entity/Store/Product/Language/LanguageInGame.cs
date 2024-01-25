namespace Ice_Hot_Tea.Entity.Store.Product.Language
{
    public class LanguageInGame
    {
        public string id { get; set; }
        public string gameId { get; set; }
        public string languageId { get; set; }
        public bool IsSubtitles { get; set; } = false;
        public bool IsAudio { get; set; } = false;
        public bool IsInterface { get; set; } = false;

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
