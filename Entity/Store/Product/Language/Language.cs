namespace Ice_Hot_Tea.Data.Entity
{
    public class Language
    {
        public String id { get; set; }
        public String name { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public Language(String id, String name, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.createdAt = createdAt;
        }
    }
}
