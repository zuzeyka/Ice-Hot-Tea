using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class GameByLanguage : DBRecord
    {
        public string gameId { get; set; }
        public string languageId { get; set; }
        public bool IsSubtitles { get; set; } = false;
        public bool IsAudio { get; set; } = false;
        public bool IsInterface { get; set; } = false;
    }
}
